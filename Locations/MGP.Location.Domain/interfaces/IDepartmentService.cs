using MGP.Location.Persistance.DTOs.Department;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MGP.Location.Domain.interfaces
{
    public interface IDepartmentService
    {
        Task<IEnumerable<DepartmentData>> GetDepartmentsByProvinceId(int provinceId);
    }
}
