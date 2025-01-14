using AutoMapper;
using MGP.Location.Client.Interface;
using MGP.Location.Domain.interfaces;
using MGP.Location.Persistance.DTOs.Province;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MGP.Location.Domain.Services
{
    public class LocalityService : ILocalityService
    {
        private readonly IGeoRefArClient _geoRefArUriClient;
        private readonly IMapper _mapper;

        public LocalityService(IGeoRefArClient geoRefArUriClient,
            IMapper mapper)
        {
            _geoRefArUriClient = geoRefArUriClient;
            _mapper = mapper;
        }

        public async Task<IEnumerable<LocalityData>> GetLocalitiesByDepartmentId(int departmentId)
        {
            return _mapper.Map<IEnumerable<LocalityData>>((await _geoRefArUriClient.GetLocalitiesByDepartmentIdAsync(departmentId.ToString())).Content.Localidades.Where(x => x.Categoria.Equals("Entidad")));
        }

        public Task<LocalityDetailDto> GetLocalityDetailById(long localityId)
        {
            throw new System.NotImplementedException();
        }
    }
}
