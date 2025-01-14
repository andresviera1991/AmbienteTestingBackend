using MGP.Location.Persistance.DTOs.Street;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MGP.Location.Domain.interfaces
{
    public interface IStreetService
    {
        Task<IEnumerable<StreetData>> GetStreetsByNameAsync(long localityId, string streetName);
    }
}
