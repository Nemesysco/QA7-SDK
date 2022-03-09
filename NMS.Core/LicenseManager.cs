using System;

using NMS.Core.Entities;
using NMS.Core.Entities.Enums;
using NMS.Core.Utility;

using QA70_com_2018;

namespace NMS.Core
{
    public static class LicenseManager
    {
        private static mngQA7ServerCls _server;
        private static readonly string _defOwner = "Nemesysco Ltd";

        private static bool IsDebugMode
        {
            get
            {
                return Convert.ToBoolean(ConfigUtility.GetValue("debugmode"));
            }
        }

        public static short Init(string licensePath, string appId = "QA7")
        {
            if (_server == null)
            {
                _server = new mngQA7ServerCls();
            }

            if (_server.nmsSDKgetProcessId() != 1)
            {
                NmsLogger.Error("licPID != 1");
                return 992;
            }

            var licFile = $"SOFTLIC:{licensePath}QA7lic.lic";
            var username = "APP";

            _ = _server.nmsSRV_ResetCounter(licFile);
            var rc = _server.nmsSRV_INIT(_defOwner, appId, username);

            if (IsDebugMode)
            {
                var li = GetInfo();
                NmsLogger.Info(
                    $"SystemID: {li.SystemId} | licensePosts {li.LicensePosts} | callsCount = {li.CallCounter} | currentlyRunning: {li.RunningInstances} | softLicFile: {licFile}");
            }

            return rc;
        }

        public static LicenseInfo GetInfo()
        {
            var li = new LicenseInfo(ServiceType.QA7);

            int callCounter = 0;
            int runningInstances = 0;
            short licensePosts = 0;

            li.CoreVersion = GetVersion();
            li.SystemId = GetOpDetails(ref callCounter, string.Empty, ref licensePosts, ref runningInstances);
            li.CallCounter = callCounter;
            li.LicensePosts = licensePosts;
            li.RunningInstances = runningInstances;
            li.MinutesCounter = GetMinuteCounter();

            return li;
        }

        public static string ToString(LicenseInfo li)
        {
            return
                $"System ID: {li.SystemId}\r\n" +
                $"License Posts: {li.LicensePosts}\r\n" +
                $"Calls Counter: {li.CallCounter}\r\n" +
                $"Running Instances: {li.RunningInstances}\r\n" +
                $"Minutes Counter: {li.MinutesCounter}\r\n" +
                $"QA7 {ConfigUtility.GetValue("version")} Tester\r\n" +
                $"Core Version: {li.CoreVersion}\r\n" +
                $"Platform: {li.PlatformType}";
        }

        public static int ResetCounter(string activationCode)
        {
            return _server.nmsSRV_ResetCounter(activationCode);
        }

        public static string GetOpDetails(ref int callCounter, string systemId, ref short licensePosts, ref int currentlyRunning)
        {
            return _server.nmsSRV_GetOpDetails(ref callCounter, systemId, ref licensePosts, ref currentlyRunning);
        }

        public static string GetRemoteAnalysisToken(int remoteProcessId, double remoteSeed)
        {
            return _server.nmsSRV_GetRemoteActivationLicense(remoteProcessId, remoteSeed);
        }

        public static string GetAnalysisToken(int remoteProcessId)
        {
            return _server.nmsSRV_GetActivationLicense(remoteProcessId);
        }

        public static string GetVersion()
        {
            return _server.nmsSRV_getVersion();
        }

        public static int GetMinuteCounter()
        {
            return _server.nmsSRV_GetMinuteCounter();
        }

        public static string GetMonthlyLicense(string remLocker)
        {
            return _server.nmsSRV_GetMonthlyLicense(remLocker);
        }

        public static void Terminate()
        {
            _server.forceShutdown();
        }
    }
}
