using AutoMapper;
using MGP.Location.Persistance.Data.Tables;
using MGP.Location.Persistance.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MGP.Location.Persistance
{
    public class ProvinceRepository : IProvinceRepository
    {
        private readonly MyDbContext _dbContext;
        private readonly IMapper _mapper;

        public ProvinceRepository(MyDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Province>> GetAll()
        {
            return await _dbContext.Provinces
                        .AsNoTracking()
                        .OrderBy(locality => locality.Name)
                        .ToListAsync();
        }

        public async Task<Province> GetProvinceById(int id)
        {
            try
            {
                return await _dbContext.Provinces
                               .AsNoTracking()
                               .FirstOrDefaultAsync(p => p.Id == id);
            }
            catch
            {
                return null;
            }
        }
    }
}