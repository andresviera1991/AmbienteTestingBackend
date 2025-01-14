using MGP.Location.Client.DTOs.Department;
using MGP.Location.Client.DTOs.Locality;
using MGP.Location.Client.DTOs.Province;
using MGP.Location.Client.Interface;
using Refit;
using System.Threading.Tasks;

namespace MGP.Location.Client
{
    public class GeoRefArClient : IGeoRefArClient
    {
        private readonly IGeoRefArApi _api;

        public GeoRefArClient(IGeoRefArApi api)
        {
            _api = api;
        }

        public async Task<ApiResponse<GetProvincesClientResult>> GetProvincesAsync()
        {
            return await _api.GetProvincesAsync();
        }

        public async Task<ApiResponse<GetLocalitiesByDepartmentIdClientResult>> GetLocalitiesByDepartmentIdAsync(string departamento, string max = "1000", string orden = "nombre", string campos = "completo")
        {
            return await _api.GetLocalitiesByDepartmentIdAsync(departamento, max, orden, campos);
        }

        public async Task<ApiResponse<GetDepartmentByProvinceIdClientResult>> GetDepartmentsByProvinceIdAsync(string provincia, string orden = "nombre", string aplanar = "true", string campos = "completo", string max = "1000")
        {
            return await _api.GetDepartmentByProvinceIdAsync(provincia, orden, aplanar, campos,max);
        }
    }
}