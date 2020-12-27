namespace Joint.Kestrel.Config
{
    static class HttpsCertificateDtoFactory
    {
        public static HttpsCertificateDto Create()
        {
            var pfxLocation = ConfigTools.GetAppSettingValue<string>("httpsCertificate:pfxLocation");
            var password = ConfigTools.GetAppSettingValue<string>("httpsCertificate:password");

            return new HttpsCertificateDto(pfxLocation, password);
        }
    }
}
