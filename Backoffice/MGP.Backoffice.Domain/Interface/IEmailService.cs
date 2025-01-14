using MGP.Backoffice.CrossCutting.Enum;

namespace MGP.Backoffice.Domain.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(string email, string subject, string bodyEmail);
        Task<string> GetEmailTemplateAsync(EmailTemplateEnum emailTemplate);
    }
}
