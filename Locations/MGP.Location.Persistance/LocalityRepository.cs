using AutoMapper;
using MGP.Location.Persistance.Data.Tables;
using MGP.Location.Persistance.DTOs.Province;
using MGP.Location.Persistance.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MGP.Location.Persistance
{
    public class LocalityRepository : ILocalityRepository
    {
        private readonly MyDbContext _dbContext;
        private readonly IMapper _mapper;

        public LocalityRepository(MyDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Locality>> GetLocalitiesByDepartmentId(int provinceId)
        {
            return await _dbContext.Localities
                        .AsNoTracking()
                        .Where(locality => locality.DepartmentId == provinceId && locality.Category.Equals("Localidad simple"))
                        .OrderBy(locality => locality.Name)
                        .ToListAsync();
        }

        public async Task<LocalityDetailDto> GetLocalityDetailById(long localityId)
        {
            return await _dbContext.Localities
                .AsNoTracking()
                .Where(locality => locality.Id == localityId)
                .Select(locality => new LocalityDetailDto
                {
                    LocalityId = locality.Id,
                    LocalityName = locality.Name,
                    DepartmentId = locality.Department.Id,
                    DepartmentName = locality.Department.Name,
                    ProvinceId = locality.Department.Province.Id,
                    ProvinceName = locality.Department.Province.Name
                })
                .FirstOrDefaultAsync();
        }
    }
}