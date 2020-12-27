namespace Joint.Kestrel.Options
{
    public class ServicePort
    {
        public int HttpPort { get; }
        public int HttpsPort { get; }
        public bool UseHttps { get; }

        public ServicePort(int httpPort, int httpsPort, bool useHttps)
        {
            HttpPort = httpPort;
            HttpsPort = httpsPort;
            UseHttps = useHttps;
        }
    }
}