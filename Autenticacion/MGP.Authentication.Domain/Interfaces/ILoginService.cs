using MGP.Authentication.Domain.Models;
using MGP.Authentication.Persistance.DTOs;
using System.Threading.Tasks;

namespace MGP.Authentication.Domain.Interfaces
{
    public interface ILoginService
    {
        Task<TokenResponse> LoginAsync(LoginData userData);

        Task LogoutAsync(string refreshToken);
        Task<TokenResponse> CreateNewSessionTokenAsync(string refreshToken);
    }
}
