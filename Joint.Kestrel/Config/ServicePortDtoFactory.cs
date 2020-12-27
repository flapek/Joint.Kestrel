using System;

namespace Joint.Kestrel.Config
{
    public static class ServicePortDtoFactory
    {
        private static int GetHttpPort(int defaultPort, int instanceId) => defaultPort + (instanceId - 1) * 200;
        private static int GetHttpsPort(int defaultPort, int instanceId) => GetHttpPort(defaultPort, instanceId) + 1;

        public static ServicePortDto CreateServicePorts()
        {
            var defaultPort = ConfigTools.GetAppSettingValue<int>("ports:defaultPort");
            var useHttps = ConfigTools.GetAppSettingValue<bool>("ports:useHttps");
            var instanceId = modStringsTools.GetCommandValue("INSTANCEID");
            if (instanceId.IsNullOrEmpty())
                instanceId = "001";
            var servicePorts = new ServicePortDto(GetHttpPort(defaultPort, Int32.Parse(instanceId)),
                GetHttpsPort(defaultPort, Int32.Parse(instanceId)), useHttps);

            return servicePorts;
        }
    }
}