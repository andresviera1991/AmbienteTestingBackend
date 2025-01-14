
using MGP.Authentication.CrossCutting.Enum;
using MGP.Authentication.Persistance.DTOs;
using System;
using System.Threading.Tasks;

namespace MGP.Authentication.Domain.Interfaces
{
    public interface IPasswordService
    {
        Task ChangePasswordAsync(ChangePasswordData request);
        Task ResetPasswordAsync(string token, string newPassword);
        Task SendEmailResetPasswordAsync(Guid id, string email, string v, EmailTemplateType resetPassword);
        Task<bool> ValidateTokenAsync(string token);

    }
}
