using MGP.Authentication.Persistance.Data.Tables;
using MGP.Authentication.Persistance.DTOs;
using MGP.Authentication.Persistance.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace MGP.Authentication.Persistance;

public class CatalogRepository : ICatalogRepository
{
    private readonly MyDbContext _dbContext;

    public CatalogRepository(MyDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Gender>> ListGenderAsync()
    {
        return await _dbContext.Set<Gender>().ToListAsync();
    }

    public async Task<List<UserData>> ListUserDataAsync()
    {
        return await _dbContext.Set<UserData>().ToListAsync();
    }
}
