using MGP.Location.Client.DTOs.Department;
using MGP.Location.Client.DTOs.Locality;
using MGP.Location.Client.DTOs.Province;
using Refit;
using System.Threading.Tasks;

namespace MGP.Location.Client.Interface
{
    public interface IGeoRefArClient
    {
        Task<ApiResponse<GetProvincesClientResult>> GetProvincesAsync();

        Task<ApiResponse<GetLocalitiesByDepartmentIdClientResult>> GetLocalitiesByDepartmentIdAsync(
            string departamento,
            string max = "1000",
            string orden = "nombre",
            string campos = "completo");

        Task<ApiResponse<GetDepartmentByProvinceIdClientResult>> GetDepartmentsByProvinceIdAsync(
            string provincia,
            string orden = "nombre",
            string aplanar = "true",
            string campos = "completo",
            string max = "1000");
    }
}
