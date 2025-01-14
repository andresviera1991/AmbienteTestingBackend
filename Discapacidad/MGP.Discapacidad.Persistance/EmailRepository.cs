using MGP.Discapacidad.CrossCutting.Enum;
using MGP.Discapacidad.Persistance.Data.Tables;
using MGP.Discapacidad.Persistance.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
namespace MGP.Discapacidad.Persistance;

public class EmailRepository : IEmailRepository
{
    private readonly MyDbContext _dbContext;

    public EmailRepository(MyDbContext dbContext)
    {
            _dbContext = dbContext;
    }
    public async Task<string> GetEmailTemplateAsync(EmailTemplateEnum emailTemplateType)
    {
        return await _dbContext.Set<EmailTemplate>().Where(t => t.Id == (int)emailTemplateType).Select(t => t.EmailHtml).SingleOrDefaultAsync();
    }
}
