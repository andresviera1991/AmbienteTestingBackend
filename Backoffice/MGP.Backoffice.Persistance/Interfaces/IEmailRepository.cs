using MGP.Backoffice.CrossCutting.Enum;
namespace MGP.Backoffice.Persistance.Interface;

public interface IEmailRepository
{
    public Task<string> GetEmailTemplateAsync(EmailTemplateEnum emailTemplateType);
}
