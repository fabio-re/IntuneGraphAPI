using Newtonsoft.Json;

namespace IntuneGraphTest.Model
{    
    public class HardwareInformation
    {
        public string serialNumber { get; set; }
        public long totalStorageSpace { get; set; }
        public long freeStorageSpace { get; set; }
        public object imei { get; set; }
        public object meid { get; set; }
        public string manufacturer { get; set; }
        public string model { get; set; }
        public object phoneNumber { get; set; }
        public object subscriberCarrier { get; set; }
        public object cellularTechnology { get; set; }
        public string wifiMac { get; set; }
        public string operatingSystemLanguage { get; set; }
        public bool isSupervised { get; set; }
        public bool isEncrypted { get; set; }
        public object batterySerialNumber { get; set; }
        public int batteryHealthPercentage { get; set; }
        public int batteryChargeCycles { get; set; }
        public bool isSharedDevice { get; set; }
        public string tpmSpecificationVersion { get; set; }
        public string operatingSystemEdition { get; set; }
        public object deviceFullQualifiedDomainName { get; set; }
        public string deviceGuardVirtualizationBasedSecurityHardwareRequirementState { get; set; }
        public string deviceGuardVirtualizationBasedSecurityState { get; set; }
        public string deviceGuardLocalSystemAuthorityCredentialGuardState { get; set; }
        public object osBuildNumber { get; set; }
        public int operatingSystemProductType { get; set; }
        public string ipAddressV4 { get; set; }
        public string subnetAddress { get; set; }
        public object esimIdentifier { get; set; }
        public string systemManagementBIOSVersion { get; set; }
        public string tpmManufacturer { get; set; }
        public string tpmVersion { get; set; }
        public List<string> wiredIPv4Addresses { get; set; }
        public double batteryLevelPercentage { get; set; }
        public object residentUsersCount { get; set; }
        public object productName { get; set; }
        public string deviceLicensingStatus { get; set; }
        public int deviceLicensingLastErrorCode { get; set; }
        public object deviceLicensingLastErrorDescription { get; set; }
        public List<object> sharedDeviceCachedUsers { get; set; }
    }
    public class HardwareInformationRoot
    {
        [JsonProperty("@odata.context")]
        public string odatacontext { get; set; }
        public string id { get; set; }
        public long physicalMemoryInBytes { get; set; }
        public HardwareInformation hardwareInformation { get; set; }
    }


}
