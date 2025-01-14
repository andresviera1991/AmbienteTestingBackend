using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace MGP.Location.API.Controllers.V1.Department.Response
{
    [SwaggerSchema("Respuesta a una solicitud para obtener la lista de departamentos de una provincia")]
    public class GetDepartmentsByProvinceIdResponseModelList
    {
        [SwaggerSchema("Lista de departamentos")]
        public IEnumerable<GetDepartmentsByProvinceIdResponseModel> Departments { get; set; }
    }
}
