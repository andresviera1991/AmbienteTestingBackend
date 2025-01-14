using AutoMapper;
using MGP.Location.Domain.interfaces;
using MGP.Location.Persistance.DTOs.Department;
using MGP.Location.Persistance.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MGP.Location.Domain.Services
{
    public class DepartmentServiceDB : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;

        public DepartmentServiceDB(
            IDepartmentRepository departmentRepository,
            IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<DepartmentData>> GetDepartmentsByProvinceId(int provinceId)
        {
            return _mapper.Map<IEnumerable<DepartmentData>>(await _departmentRepository.GetDepartmentsByProvinceId(provinceId));
        }
    }
}
