using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace MGP.Location.API.Controllers.V1.Locality.Response
{
    [SwaggerSchema("Respuesta a una solicitud para obtener la lista de localidades de un departamento")]
    public class GetLocalitiesByDepartmentIdResponseModelList
    {
        [SwaggerSchema("Lista de localidades")]
        public IEnumerable<GetLocalitiesByDepartmentIdResponseModel> Localities { get; set; }
    }
}
