using MGP.Backoffice.Domain.Models;
using MGP.Backoffice.Persistance.DTOs;

namespace MGP.Backoffice.Domain.Interface
{
    public interface ILoginService
    {
        Task ChangePasswordAsync(ChangePasswordData changePasswordData);
        Task<TokenResponse> CreateNewSessionTokens(string refreshToken);
        Task<TokenResponse> LoginAsync(LoginData userData);
        Task LogoutAsync(string refreshToken);
        Task ResetPasswordAsync(string employeeNumber);
        //Task LogoutAsync(string refreshToken);
        //Task<TokenResponse> CreateNewSessionTokenAsync(string refreshToken);
    }
}
