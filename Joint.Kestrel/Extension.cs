using Joint.Kestrel.Config;
using Microsoft.AspNetCore.Hosting;
using System.Net;

namespace Joint.Kestrel
{
    public static class Extension
    {

        public static IWebHostBuilder UseRomicoKestrel(this IWebHostBuilder builder)
        {
            var servicePorts = ServicePortDtoFactory.CreateServicePorts();

            builder.UseKestrel(opt =>
            {
                opt.Listen(IPAddress.Any, servicePorts.HttpPort);
                if (servicePorts.UseHttps)
                {
                    opt.Listen(IPAddress.Any, servicePorts.HttpsPort, options =>
                    {
                        var certificate = HttpsCertificateDtoFactory.Create();
                        options.UseHttps(certificate.PfxLocation, certificate.Password);
                    });
                }
            });

            return builder;
        }
    }
}
