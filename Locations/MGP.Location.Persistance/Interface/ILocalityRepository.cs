using MGP.Location.Persistance.Data.Tables;
using MGP.Location.Persistance.DTOs.Province;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MGP.Location.Persistance.Interface
{
    public interface ILocalityRepository
    {
        Task<IEnumerable<Locality>> GetLocalitiesByDepartmentId(int provinceId);
        Task<LocalityDetailDto> GetLocalityDetailById(long localityId);
    }
}
