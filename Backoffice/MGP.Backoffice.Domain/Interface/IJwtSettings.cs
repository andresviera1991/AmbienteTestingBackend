
namespace MGP.Backoffice.Domain.Interfaces
{
    public interface IJwtSettings
    {
        public string SecretKey { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
    }
}
