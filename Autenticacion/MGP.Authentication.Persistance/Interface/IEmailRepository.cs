using MGP.Authentication.CrossCutting.Enum;
using System.Threading.Tasks;
namespace MGP.Authentication.Persistance.Interface;

public interface IEmailRepository
{
    public Task<string> GetEmailTemplateAsync(EmailTemplateType emailTemplateType);
}
