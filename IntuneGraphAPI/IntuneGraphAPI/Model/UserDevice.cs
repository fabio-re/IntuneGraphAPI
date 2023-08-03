using System.Text.Json.Serialization;

namespace IntuneGraphTest.Model
{    
    public class UserDevice
    {       
        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public string DiskCapacity { get; set; }

        public string FreeDiskMemory { get; set; }

        public string RAM { get; set; }

        public string OperatingSystem { get; set; }  

        public string serialNumber { get; set; }

        public DateTime EnrollDate { get; set; }

        public string ManagedDeviceName { get; set; }
    }

}