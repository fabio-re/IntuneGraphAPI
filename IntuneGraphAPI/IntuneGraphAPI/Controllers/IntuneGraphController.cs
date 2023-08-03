using IntuneGraphAPI.Models;
using IntuneGraphAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.Graph;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Azure;
using IntuneGraphTest.Model;
using Microsoft.IdentityModel.Tokens;
using Device = IntuneGraphTest.Model.Device;
using Newtonsoft.Json;
using Azure.Core;

namespace IntuneGraph.Method
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntuneGraphController : ControllerBase
    {
        #region fields
        private readonly IGraphService _graphService;
        private readonly ConfigurationObj _configurationObj;
        #endregion
        public IntuneGraphController(IGraphService graphService, IOptions<ConfigurationObj> configurationObj)
        {
            //_logger = logger;
            _graphService = graphService;
            _configurationObj = configurationObj?.Value ?? throw new ArgumentNullException(nameof(configurationObj));
        }
        [HttpGet("GetUserIdAsync")]
        public async Task<IActionResult> GetUserIdAsync(string user)
        {
            try
            {
                var graphServiceClient = await _graphService.GetAuthGraphServiceClient(_configurationObj.TenantId, _configurationObj.ClientIdAppReg, _configurationObj.ClientSecretAppReg);
                var userid = await GetUserIdFromPrincipalName(user, graphServiceClient);
                return Ok(userid);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetManagedDevicesAsync")]
        public async Task<IActionResult> GetManagedDevicesAsync(string user)
        {
            List<UserDevice> userDevices = new List<UserDevice>();
            try
            {
                var accessToken = await _graphService.GetTokenFromGraphAsync(_configurationObj.TenantId, _configurationObj.ClientIdAppReg, _configurationObj.ClientSecretAppReg);

                var requestUrl = $"https://graph.microsoft.com/beta/users/{user}/managedDevices";
                var responseString = await _graphService.CallGraphMethod(HttpMethod.Get, requestUrl, accessToken);
                if (!responseString.IsNullOrEmpty())
                {
                    GraphResponseRoot? _graphResponseObj = System.Text.Json.JsonSerializer.Deserialize<GraphResponseRoot>(responseString);
                    foreach (var r in _graphResponseObj.value)
                    {
                        var dev = await GetDeviceHardwareInfo(r.id, accessToken);
                        HardwareInformationRoot userDeviceHWInfo = JsonConvert.DeserializeObject<HardwareInformationRoot>(dev);
                        HardwareInformation userDeviceHW = userDeviceHWInfo.hardwareInformation;
                        userDevices.Add(new UserDevice
                        {
                            ManagedDeviceName = r.managedDeviceName,
                            EnrollDate = r.enrolledDateTime,
                            Model = userDeviceHW.model,
                            Manufacturer = userDeviceHW.manufacturer,
                            serialNumber = userDeviceHW.serialNumber,
                            OperatingSystem = $"{r.operatingSystem}-{userDeviceHW.operatingSystemEdition} ({userDeviceHW.operatingSystemLanguage})",
                            RAM = Math.Truncate(Convert.ToDecimal(userDeviceHWInfo.physicalMemoryInBytes) / (1024.0m * 1024.0m) / 1000) + " GB",
                            DiskCapacity = Math.Truncate(Convert.ToDecimal(userDeviceHW.totalStorageSpace) / (1024.0m * 1024.0m) / 1000) + " GB",
                            FreeDiskMemory = Math.Truncate(Convert.ToDecimal(userDeviceHW.freeStorageSpace) / (1024.0m * 1024.0m) / 1000) + " GB"
                        });
                    }
                }
                return Ok(userDevices);
            }
            catch (Exception ex)
            {
                return BadRequest($"Errore: {ex.Message};  InnerException = {ex.InnerException}, StackTrace = {ex.StackTrace}");
            }
        }

        private static async Task<string?> GetUserIdFromPrincipalName(string? userPrincipalName, GraphServiceClient graphAuth)
        {
            if (String.IsNullOrWhiteSpace(userPrincipalName))
                return String.Empty;

            var usersId = await graphAuth.Users
                        .Request()
                        .Filter($"UserPrincipalName eq '{userPrincipalName}'")
                        .Select(u => u.Id)
                        .GetAsync();

            return usersId.FirstOrDefault()?.Id;
        }
        private async Task<string?> GetDeviceHardwareInfo(string deviceID, string accessToken)
        {
            var requestUrl = $"https://graph.microsoft.com/beta/deviceManagement/manageddevices('{deviceID}')?$select=id,hardwareinformation,physicalMemoryInBytes";
            try
            {
                var responseString = await _graphService.CallGraphMethod(HttpMethod.Get, requestUrl, accessToken);
                if (!responseString.IsNullOrEmpty())
                {
                    return responseString;
                }
                else
                { return ""; }
            }
            catch (Exception ex) { return ""; }
        }
    }
}
