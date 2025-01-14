using MGP.Backoffice.CrossCutting.Exceptions;
using MGP.Backoffice.Persistance.Data.Tables;
using MGP.Backoffice.Persistance.Interfaces;
using MGP.Backoffice.Persistence.Data.Tables;
using Microsoft.EntityFrameworkCore;
namespace MGP.Backoffice.Persistance;

public class AreaRepository : IAreaRepository
{
    private readonly MyDbContext _dbContext;

    public AreaRepository(MyDbContext myDbContext)
    {
        _dbContext = myDbContext;
    }

    public async Task<bool> AreaExistsAsync(int areaId)
    {
        return await _dbContext.Set<Area>().Where(a => a.Id == areaId).AnyAsync();
    }

    public async Task<Area> FindByIdAsync(int areaId)
    {
        return await _dbContext.Set<Area>().Where(a => a.Id == areaId).SingleOrDefaultAsync() ?? throw new AreaNotFoundException(); ;
    }

    public async Task<Area> FindByNameAsync(string areaName)
    {
        return await _dbContext.Set<Area>().Where(a => a.Name.Equals(areaName)).FirstOrDefaultAsync() ?? throw new AreaNotFoundException();
    }
}
