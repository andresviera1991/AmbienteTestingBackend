using MGP.Authentication.CrossCutting.Enum;
using System.Threading.Tasks;

namespace MGP.Authentication.Domain.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(string email, string subject, string bodyEmail);
        Task<string> GetEmailTemplateAsync(EmailTemplateType emailTemplate);
    }
}
