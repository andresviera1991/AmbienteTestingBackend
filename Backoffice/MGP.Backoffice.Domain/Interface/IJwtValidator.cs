using MGP.Backoffice.Domain.Models;

namespace MGP.Backoffice.Domain.Interface
{
    public interface IJwtValidator
    {
        Task<TokenInformation> ValidateRefreshTokenAsync(string token);
    }
}