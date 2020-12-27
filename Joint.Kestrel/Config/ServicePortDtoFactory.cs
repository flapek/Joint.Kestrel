using Joint.Kestrel.Options;
using System;

namespace Joint.Kestrel.Config
{
    public static class ServicePortDtoFactory
    {
        private static int GetHttpPort(int defaultPort, int instanceId) => defaultPort + (instanceId - 1) * 200;
        private static int GetHttpsPort(int defaultPort, int instanceId) => GetHttpPort(defaultPort, instanceId) + 1;

        public static ServicePort CreateServicePorts()
        {
            
            var defaultPort = ConfigTools.GetAppSettingValue<int>("ports:defaultPort");
            var useHttps = ConfigTools.GetAppSettingValue<bool>("ports:useHttps");
            var instanceId = modStringsTools.GetCommandValue("INSTANCEID");
            if (instanceId.IsNullOrEmpty())
                instanceId = "001";
            var servicePorts = new ServicePort(GetHttpPort(defaultPort, int.Parse(instanceId)),
                GetHttpsPort(defaultPort, int.Parse(instanceId)), useHttps);

            return servicePorts;
        }
    }
}