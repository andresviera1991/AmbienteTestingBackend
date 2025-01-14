using MGP.Authentication.Persistance.Data.Tables;
using System;
using System.Threading.Tasks;

namespace MGP.Authentication.Persistance.Interface
{
    public interface ILoginRepository
    {
        Task<User> GetUserByUserIdAsync(Guid userId);
        Task<User> GetUserByUserNameAsync(string userName);
        Task IncrementFailedLoginsAsync(User user);
        Task ResetFailedLoginAsync(User user);
        Task RevokeRefreshSessionTokenAsync(string refreshToken, Guid userId, DateTime expirationDate);
    }
}
