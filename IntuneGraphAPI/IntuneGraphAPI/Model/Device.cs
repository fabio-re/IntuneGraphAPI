using System.Text.Json.Serialization;

namespace IntuneGraphTest.Model
{    
    public class Device
    {
        [JsonPropertyName("@odata.type")]
        public string odatatype { get; set; }

        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("deletedDateTime")]
        public object deletedDateTime { get; set; }

        [JsonPropertyName("accountEnabled")]
        public bool accountEnabled { get; set; }

        [JsonPropertyName("approximateLastSignInDateTime")]
        public DateTime approximateLastSignInDateTime { get; set; }

        [JsonPropertyName("complianceExpirationDateTime")]
        public object complianceExpirationDateTime { get; set; }

        [JsonPropertyName("createdDateTime")]
        public DateTime createdDateTime { get; set; }

        [JsonPropertyName("deviceCategory")]
        public object deviceCategory { get; set; }

        [JsonPropertyName("deviceId")]
        public string deviceId { get; set; }

        [JsonPropertyName("deviceMetadata")]
        public object deviceMetadata { get; set; }

        [JsonPropertyName("deviceOwnership")]
        public string deviceOwnership { get; set; }

        [JsonPropertyName("deviceVersion")]
        public int deviceVersion { get; set; }

        [JsonPropertyName("displayName")]
        public string displayName { get; set; }

        [JsonPropertyName("domainName")]
        public object domainName { get; set; }

        [JsonPropertyName("enrollmentProfileName")]
        public object enrollmentProfileName { get; set; }

        [JsonPropertyName("enrollmentType")]
        public string enrollmentType { get; set; }

        [JsonPropertyName("externalSourceName")]
        public object externalSourceName { get; set; }

        [JsonPropertyName("isCompliant")]
        public bool isCompliant { get; set; }

        [JsonPropertyName("isManaged")]
        public bool isManaged { get; set; }

        [JsonPropertyName("isRooted")]
        public bool isRooted { get; set; }

        [JsonPropertyName("managementType")]
        public string managementType { get; set; }

        [JsonPropertyName("manufacturer")]
        public string manufacturer { get; set; }

        [JsonPropertyName("mdmAppId")]
        public string mdmAppId { get; set; }

        [JsonPropertyName("model")]
        public string model { get; set; }

        [JsonPropertyName("onPremisesLastSyncDateTime")]
        public object onPremisesLastSyncDateTime { get; set; }

        [JsonPropertyName("onPremisesSyncEnabled")]
        public object onPremisesSyncEnabled { get; set; }

        [JsonPropertyName("operatingSystem")]
        public string operatingSystem { get; set; }

        [JsonPropertyName("operatingSystemVersion")]
        public string operatingSystemVersion { get; set; }

        [JsonPropertyName("physicalIds")]
        public List<string> physicalIds { get; set; }

        [JsonPropertyName("profileType")]
        public string profileType { get; set; }

        [JsonPropertyName("registrationDateTime")]
        public DateTime registrationDateTime { get; set; }

        [JsonPropertyName("sourceType")]
        public object sourceType { get; set; }

        [JsonPropertyName("systemLabels")]
        public List<object> systemLabels { get; set; }

        [JsonPropertyName("trustType")]
        public string trustType { get; set; }

     
        
    }

}