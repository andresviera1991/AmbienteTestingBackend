using MGP.Backoffice.CrossCutting.Enum;
using MGP.Backoffice.Persistance.Data.Tables;
using MGP.Backoffice.Persistance.Interface;
using MGP.Backoffice.Persistence.Data.Tables;
using Microsoft.EntityFrameworkCore;

namespace MGP.Backoffice.Persistance;

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
