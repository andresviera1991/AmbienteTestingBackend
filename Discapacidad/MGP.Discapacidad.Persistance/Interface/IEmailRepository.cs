using MGP.Discapacidad.CrossCutting.Enum;
using System.Threading.Tasks;
namespace MGP.Discapacidad.Persistance.Interface;

public interface IEmailRepository
{
    Task<string> GetEmailTemplateAsync(EmailTemplateEnum emailTemplateType);
}
