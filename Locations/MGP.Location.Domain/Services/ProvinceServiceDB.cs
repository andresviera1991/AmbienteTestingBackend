using AutoMapper;
using MGP.Location.Domain.interfaces;
using MGP.Location.Persistance.DTOs.Province;
using MGP.Location.Persistance.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MGP.Location.Domain.Services
{
    public class ProvinceServiceDB : IProvinceService
    {
        private readonly IProvinceRepository _provinceRepository;
        private readonly IMapper _mapper;

        public ProvinceServiceDB(IProvinceRepository provinceRepository,
            IMapper mapper)
        {
            _provinceRepository = provinceRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProvinceData>> GetAll()
        {
            return _mapper.Map<IEnumerable<ProvinceData>>((await _provinceRepository.GetAll()));
        }

        public async Task<ProvinceData> GetProvinceById(int provinceId)
        {
            return _mapper.Map<ProvinceData>(await _provinceRepository.GetProvinceById(provinceId));
        }
    }
}
