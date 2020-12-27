namespace Joint.Kestrel.Config
{
    class HttpsCertificateDto
    {
        public string PfxLocation { get; }
        public string Password { get; }
        public HttpsCertificateDto(string pfxLocation, string password)
        {
            Password = password;
            PfxLocation = pfxLocation;
        }
    }
}
