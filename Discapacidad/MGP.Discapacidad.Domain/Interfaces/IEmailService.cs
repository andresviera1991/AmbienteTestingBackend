using MGP.Discapacidad.CrossCutting.Enum;
using System.Threading.Tasks;
namespace MGP.Discapacidad.Domain.interfaces;

public interface IEmailService
{
    Task SendEmailHandlerAsync(string email, string subject, string emailBody);
    public Task<string> GetEmailTemplateAsync(EmailTemplateEnum emailTemplate);

}
