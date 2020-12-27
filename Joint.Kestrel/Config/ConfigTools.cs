using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Joint.Kestrel.Config
{
    public class ConfigTools
    {
        public static T GetAppSettingValue<T>(string appSettingKey)
        {
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
            var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var config1 = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true)
                .AddJsonFile($"appsettings.{env}.json", true)
                .Build();
            var defaultPort = config1.GetValue<T>(appSettingKey);
            return defaultPort;
        }
    }
}