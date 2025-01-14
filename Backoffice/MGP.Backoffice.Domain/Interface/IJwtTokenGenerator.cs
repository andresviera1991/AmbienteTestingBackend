using MGP.Backoffice.Domain.Models;
using MGP.Backoffice.Persistence.Data.Tables;

namespace MGP.Backoffice.Domain.Interfaces
{
    public interface IJwtTokenGenerator
    {
        Task<TokenResponse> GenerateSessionTokenAsync(User user, Role role);
    }
}