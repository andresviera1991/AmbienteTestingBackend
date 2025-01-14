using MGP.Location.Persistance.Data.Tables;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MGP.Location.Persistance.Interface
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetDepartmentsByProvinceId(int departmentId);
    }
}
