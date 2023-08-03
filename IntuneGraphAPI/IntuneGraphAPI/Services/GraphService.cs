using Microsoft.Graph;
using Microsoft.Graph.Auth;
using Microsoft.Identity.Client;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace IntuneGraphAPI.Services
{
    public class GraphService : IGraphService
    {
        #region fields
        //private readonly ILogger<GraphService> _logger;
        #endregion

        #region constructors
        public GraphService()
        {
            //_logger = logger;
        }
        #endregion

        public async Task<string> GetTokenFromGraphAsync(string tenantId, string clientId, string clientSecret)
        {
            //_logger.LogInformation($"Start GetAuthGraphServiceClient(tenantId={tenantId}, clientId={clientId}, clientSecret={clientSecret})");

            IConfidentialClientApplication confidentialClientApplication = ConfidentialClientApplicationBuilder
                .Create(clientId)
                .WithTenantId(tenantId)
                .WithClientSecret(clientSecret)
                .Build();
   
            try
            {
                var _scopes = new List<string> { "https://graph.microsoft.com/.default" };
                var authenticationResult = await confidentialClientApplication.AcquireTokenForClient(_scopes).ExecuteAsync();
                
                return authenticationResult.AccessToken;               
            }
            catch (Exception ex)
            {
                throw;
            }          
        }
        public async Task<string?> CallGraphMethod(HttpMethod httpMethod, string requestUrl, string accessToken)
        {
            string responseString = null;
            using (var httpClient = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage(httpMethod, requestUrl);
                request.Headers.Add("Accept", "application/json;odata.metadata=minimal");
                //request.Headers.Add("Content-Type", "application/json");
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                dynamic objBody = new System.Dynamic.ExpandoObject();
                objBody.expirationDateTime = DateTime.UtcNow.AddDays(1).ToUniversalTime();

                request.Content = new StringContent(JsonSerializer.Serialize(objBody), Encoding.UTF8, "application/json");

                HttpResponseMessage response = await httpClient.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    responseString = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    // Something went wrong...
                    var err = await response.Content.ReadAsStringAsync();
                    throw new Exception(err);
                }
            }
            return responseString; 
        }
        public async Task<GraphServiceClient> GetAuthGraphServiceClient(string tenantId, string clientId, string clientSecret)
        {

            IConfidentialClientApplication confidentialClientApplication = ConfidentialClientApplicationBuilder
                .Create(clientId)
                .WithTenantId(tenantId)
            .WithClientSecret(clientSecret)
            .Build();

            ClientCredentialProvider authProvider = new ClientCredentialProvider(confidentialClientApplication);
            GraphServiceClient graphClient = new GraphServiceClient(authProvider);

            return graphClient;
        }
    }
}
