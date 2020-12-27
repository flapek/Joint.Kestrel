namespace Joint.Kestrel.Config
{
    public class ServicePortDto
    {
        public int HttpPort { get; }
        public int HttpsPort { get; }
        public bool UseHttps { get; }

        public ServicePortDto(int httpPort, int httpsPort, bool useHttps)
        {
            HttpPort = httpPort;
            HttpsPort = httpsPort;
            UseHttps = useHttps;
        }
    }
}