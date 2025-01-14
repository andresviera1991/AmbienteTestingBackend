using MGP.Backoffice.Domain.Interface;
using MGP.Backoffice.Persistance.Data.Tables;
using MGP.Backoffice.Persistence.Data.Tables;
using Microsoft.EntityFrameworkCore;
namespace MGP.Backoffice.Domain;
public class CatalogRepository : ICatalogRepository
{
    private readonly MyDbContext _dbContext;

    public CatalogRepository(MyDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Area>> GetAreas()
    {
        return await _dbContext.Set<Area>().ToListAsync();
    }

    public async Task<List<Role>> GetRoles()
    {
        return await _dbContext.Set<Role>().ToListAsync();
    }

    public async Task<List<TicketType>> GetTicketByAreaAsync(string area)
    {
        return await _dbContext.Set<TicketType>().Where(t => t.Area.Name.Equals(area)).ToListAsync();
    }

    public async Task<List<UserStatus>> ListUserStatusAsync()
    {
        return await _dbContext.Set<UserStatus>().ToListAsync();
    }
}
