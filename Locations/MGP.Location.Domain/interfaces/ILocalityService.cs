using MGP.Location.Persistance.DTOs.Province;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MGP.Location.Domain.interfaces
{
    public interface ILocalityService
    {
        Task<IEnumerable<LocalityData>> GetLocalitiesByDepartmentId(int provinceId);
        Task<LocalityDetailDto> GetLocalityDetailById(long localityId);
    }
}
