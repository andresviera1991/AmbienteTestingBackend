using MGP.Authentication.Domain.Models;
using System.Threading.Tasks;

namespace MGP.Authentication.Domain.Interfaces
{
    public interface IJwtValidator
    {
        Task<TokenInformation> ValidateEmailTokenAsync(string token);
        Task<TokenInformation> ValidateRefreshTokenAsync(string token);
    }
}
