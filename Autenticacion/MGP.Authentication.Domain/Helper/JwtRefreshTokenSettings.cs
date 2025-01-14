using MGP.Authentication.Domain.Interfaces;

namespace MGP.Authentication.Domain.Helper
{
    public class JwtRefreshTokenSettings : IJwtSettings
    {
        public string SecretKey { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
    }
}
