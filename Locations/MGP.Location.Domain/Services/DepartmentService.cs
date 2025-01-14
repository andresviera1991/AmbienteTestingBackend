using AutoMapper;
using MGP.Location.Client.Interface;
using MGP.Location.Domain.interfaces;
using MGP.Location.Persistance.DTOs.Department;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MGP.Location.Domain.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IGeoRefArClient _geoRefArUriClient;
        private readonly IMapper _mapper;

        public DepartmentService(
            IGeoRefArClient geoRefArUriClient,
            IMapper mapper)
        {
            _geoRefArUriClient = geoRefArUriClient;
            _mapper = mapper;
        }

        public async Task<IEnumerable<DepartmentData>> GetDepartmentsByProvinceId(int provinceId)
        {
            return _mapper.Map<IEnumerable<DepartmentData>>((await _geoRefArUriClient.GetDepartmentsByProvinceIdAsync(provinceId.ToString())).Content.Departamentos);
        }
    }
}
