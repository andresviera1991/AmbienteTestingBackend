using MGP.Location.Client.DTOs.Department;
using MGP.Location.Client.DTOs.Locality;
using MGP.Location.Client.DTOs.Province;
using Refit;
using System.Threading.Tasks;

namespace MGP.Location.Client.Interface
{
    [Headers("Content-Type: application/json")]
    public interface IGeoRefArApi
    {
        [Get("/provincias")]
        Task<ApiResponse<GetProvincesClientResult>> GetProvincesAsync();

        [Get("/localidades")]
        Task<ApiResponse<GetLocalitiesByDepartmentIdClientResult>> GetLocalitiesByDepartmentIdAsync(
            [Query] string departamento,
            [Query] string max = "1000",
            [Query] string orden = "nombre",
            [Query] string campos = "completo");

        [Get("/departamentos")]
        Task<ApiResponse<GetDepartmentByProvinceIdClientResult>> GetDepartmentByProvinceIdAsync(
            [Query] string provincia,
            [Query] string orden = "nombre",
            [Query] string aplanar = "true",
            [Query] string campos = "completo",
            [Query] string max = "1000");
    }
}
