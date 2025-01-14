using MGP.Location.Persistance.Data.Tables;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MGP.Location.Persistance.Interface
{
    public interface IProvinceRepository
    {
        Task<IEnumerable<Province>> GetAll();
        Task<Province> GetProvinceById(int id);
    }
}
