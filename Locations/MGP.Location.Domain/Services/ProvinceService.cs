using AutoMapper;
using MGP.Location.Client.Interface;
using MGP.Location.Domain.interfaces;
using MGP.Location.Persistance.DTOs.Province;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MGP.Location.Domain.Services
{
    public class ProvinceService : IProvinceService
    {
        private readonly IGeoRefArClient _geoRefArUriClient;
        private readonly IMapper _mapper;

        public ProvinceService(IGeoRefArClient geoRefArUriClient,
            IMapper mapper)
        {
            _geoRefArUriClient = geoRefArUriClient;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProvinceData>> GetAll()
        {
            return _mapper.Map<IEnumerable<ProvinceData>>((await _geoRefArUriClient.GetProvincesAsync()).Content.Provincias);
        }
    }
}
