using MGP.Authentication.CrossCutting.Enum;
using MGP.Authentication.Persistance.Data.Tables;
using MGP.Authentication.Persistance.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace MGP.Authentication.Persistance;

public class EmailRepository : IEmailRepository
{
    private readonly MyDbContext _dbContext;

    public EmailRepository(MyDbContext dbContext)
    {
            _dbContext = dbContext;
    }
    public async Task<string> GetEmailTemplateAsync(EmailTemplateType emailTemplateType)
    {
        return await _dbContext.Set<EmailTemplate>().Where(t => t.Id == (int)emailTemplateType).Select(t => t.EmailHtml).SingleOrDefaultAsync();
    }
}
