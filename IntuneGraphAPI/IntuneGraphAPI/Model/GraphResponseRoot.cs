using System.Text.Json.Serialization;

namespace IntuneGraphTest.Model
{    
    public class GraphResponseRoot
    {
        [JsonPropertyName("@odata.context")]
        public string odatacontext { get; set; }

        [JsonPropertyName("value")]
        public List<Value> value { get; set; }
    }

    public class Value
    {
        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("userId")]
        public string userId { get; set; }

        [JsonPropertyName("deviceName")]
        public string deviceName { get; set; }

        [JsonPropertyName("managedDeviceOwnerType")]
        public string managedDeviceOwnerType { get; set; }

        [JsonPropertyName("enrolledDateTime")]
        public DateTime enrolledDateTime { get; set; }

        [JsonPropertyName("lastSyncDateTime")]
        public DateTime lastSyncDateTime { get; set; }

        [JsonPropertyName("operatingSystem")]
        public string operatingSystem { get; set; }

        [JsonPropertyName("complianceState")]
        public string complianceState { get; set; }

        [JsonPropertyName("jailBroken")]
        public string jailBroken { get; set; }

        [JsonPropertyName("managementAgent")]
        public string managementAgent { get; set; }

        [JsonPropertyName("osVersion")]
        public string osVersion { get; set; }

        [JsonPropertyName("easActivated")]
        public bool easActivated { get; set; }

        [JsonPropertyName("easDeviceId")]
        public string easDeviceId { get; set; }

        [JsonPropertyName("easActivationDateTime")]
        public DateTime easActivationDateTime { get; set; }

        [JsonPropertyName("azureADRegistered")]
        public bool azureADRegistered { get; set; }

        [JsonPropertyName("deviceEnrollmentType")]
        public string deviceEnrollmentType { get; set; }

        [JsonPropertyName("activationLockBypassCode")]
        public object activationLockBypassCode { get; set; }

        [JsonPropertyName("emailAddress")]
        public string emailAddress { get; set; }

        [JsonPropertyName("azureADDeviceId")]
        public string azureADDeviceId { get; set; }

        [JsonPropertyName("deviceRegistrationState")]
        public string deviceRegistrationState { get; set; }

        [JsonPropertyName("deviceCategoryDisplayName")]
        public string deviceCategoryDisplayName { get; set; }

        [JsonPropertyName("isSupervised")]
        public bool isSupervised { get; set; }

        [JsonPropertyName("exchangeLastSuccessfulSyncDateTime")]
        public DateTime exchangeLastSuccessfulSyncDateTime { get; set; }

        [JsonPropertyName("exchangeAccessState")]
        public string exchangeAccessState { get; set; }

        [JsonPropertyName("exchangeAccessStateReason")]
        public string exchangeAccessStateReason { get; set; }

        [JsonPropertyName("remoteAssistanceSessionUrl")]
        public object remoteAssistanceSessionUrl { get; set; }

        [JsonPropertyName("remoteAssistanceSessionErrorDetails")]
        public object remoteAssistanceSessionErrorDetails { get; set; }

        [JsonPropertyName("isEncrypted")]
        public bool isEncrypted { get; set; }

        [JsonPropertyName("userPrincipalName")]
        public string userPrincipalName { get; set; }

        [JsonPropertyName("model")]
        public string model { get; set; }

        [JsonPropertyName("manufacturer")]
        public string manufacturer { get; set; }

        [JsonPropertyName("imei")]
        public string imei { get; set; }

        [JsonPropertyName("complianceGracePeriodExpirationDateTime")]
        public DateTime complianceGracePeriodExpirationDateTime { get; set; }

        [JsonPropertyName("serialNumber")]
        public string serialNumber { get; set; }

        [JsonPropertyName("phoneNumber")]
        public string phoneNumber { get; set; }

        [JsonPropertyName("androidSecurityPatchLevel")]
        public string androidSecurityPatchLevel { get; set; }

        [JsonPropertyName("userDisplayName")]
        public string userDisplayName { get; set; }

        [JsonPropertyName("configurationManagerClientEnabledFeatures")]
        public object configurationManagerClientEnabledFeatures { get; set; }

        [JsonPropertyName("wiFiMacAddress")]
        public string wiFiMacAddress { get; set; }

        [JsonPropertyName("deviceHealthAttestationState")]
        public object deviceHealthAttestationState { get; set; }

        [JsonPropertyName("subscriberCarrier")]
        public string subscriberCarrier { get; set; }

        [JsonPropertyName("meid")]
        public string meid { get; set; }

        [JsonPropertyName("totalStorageSpaceInBytes")]
        public long totalStorageSpaceInBytes { get; set; }

        [JsonPropertyName("freeStorageSpaceInBytes")]
        public long freeStorageSpaceInBytes { get; set; }

        [JsonPropertyName("managedDeviceName")]
        public string managedDeviceName { get; set; }

        [JsonPropertyName("partnerReportedThreatState")]
        public string partnerReportedThreatState { get; set; }

        [JsonPropertyName("requireUserEnrollmentApproval")]
        public object requireUserEnrollmentApproval { get; set; }

        [JsonPropertyName("managementCertificateExpirationDate")]
        public DateTime managementCertificateExpirationDate { get; set; }

        [JsonPropertyName("iccid")]
        public object iccid { get; set; }

        [JsonPropertyName("udid")]
        public object udid { get; set; }

        [JsonPropertyName("notes")]
        public object notes { get; set; }

        [JsonPropertyName("ethernetMacAddress")]
        public object ethernetMacAddress { get; set; }

        [JsonPropertyName("physicalMemoryInBytes")]
        public int physicalMemoryInBytes { get; set; }

        [JsonPropertyName("deviceActionResults")]
        public List<object> deviceActionResults { get; set; }
    }



}