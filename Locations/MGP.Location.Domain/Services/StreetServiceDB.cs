using AutoMapper;
using MGP.Location.Domain.interfaces;
using MGP.Location.Persistance.DTOs.Street;
using MGP.Location.Persistance.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MGP.Location.Domain.Services
{
    public class StreetServiceDB : IStreetService
    {
        private readonly IStreetRepository _streetRepository;
        private readonly IMapper _mapper;

        public StreetServiceDB(IStreetRepository streetRepository,
            IMapper mapper)
        {
            _streetRepository = streetRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<StreetData>> GetStreetsByNameAsync(long localityId, string streetName)
        {
            return _mapper.Map<IEnumerable<StreetData>>(await _streetRepository.GetStreetsByNameAsync(localityId, streetName));
        }
    }
}
