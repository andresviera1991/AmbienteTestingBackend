using AutoMapper;
using MGP.Location.Domain.interfaces;
using MGP.Location.Persistance.DTOs.Province;
using MGP.Location.Persistance.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MGP.Location.Domain.Services
{
    public class LocalityServiceDB : ILocalityService
    {
        private readonly ILocalityRepository _localityRepository;
        private readonly IMapper _mapper;

        public LocalityServiceDB(ILocalityRepository localityRepository,
            IMapper mapper)
        {
            _localityRepository = localityRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<LocalityData>> GetLocalitiesByDepartmentId(int departmentId)
        {
            return _mapper.Map<IEnumerable<LocalityData>>(await _localityRepository.GetLocalitiesByDepartmentId(departmentId));
        }

        public async Task<LocalityDetailDto> GetLocalityDetailById(long localityId)
        {
            return await _localityRepository.GetLocalityDetailById(localityId);
        }
    }
}
