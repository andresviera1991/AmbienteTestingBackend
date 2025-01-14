using System;
using System.Threading.Tasks;

namespace MGP.Authentication.Persistance.Interface
{
    public interface IPasswordRepository
    {
        Task ResetPasswordAsync(Guid userId, string newPassword);
        Task SaveChangePasswordAsync();
        Task<bool> UserExistsAsync(Guid userId);
    }
}
