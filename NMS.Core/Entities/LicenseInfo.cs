using System;

using NMS.Core.Entities.Enums;

namespace NMS.Core.Entities
{
    public class LicenseInfo
    {
        public ServiceType TypeOfService { get; set; }
        public string SystemId { get; set; }
        public int LicensePosts { get; set; }
        public int RunningInstances { get; set; }
        public int CallCounter { get; set; }
        public int MinutesCounter { get; set; }
        public string APIVersion { get; set; }
        public string AppVersion { get; set; }
        public string CoreVersion { get; set; }
        public string PlatformType { get; set; } = IntPtr.Size == 8 ? "x64" : "x86";


        public LicenseInfo(ServiceType type)
        {
            TypeOfService = type;
        }
    }
}
