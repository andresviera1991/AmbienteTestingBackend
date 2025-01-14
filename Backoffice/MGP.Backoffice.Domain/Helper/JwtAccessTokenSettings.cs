using MGP.Backoffice.Domain.Interfaces;

namespace MGP.Backoffice.Domain.Helper
{
    public class JwtAccessTokenSettings : IJwtSettings
    {
        public string SecretKey { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
    }
}
