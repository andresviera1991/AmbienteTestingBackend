using AutoMapper;
using MGP.Location.Persistance.Data.Tables;
using MGP.Location.Persistance.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MGP.Location.Persistance
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly MyDbContext _dbContext;
        private readonly IMapper _mapper;

        public DepartmentRepository(MyDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Department>> GetDepartmentsByProvinceId(int provinceId)
        {
            return await _dbContext.Departments
                        .AsNoTracking()
                        .Where(d => d.ProvinceId == provinceId)
                        .OrderBy(x => x.Name)
                        .ToListAsync();
        }
    }
}