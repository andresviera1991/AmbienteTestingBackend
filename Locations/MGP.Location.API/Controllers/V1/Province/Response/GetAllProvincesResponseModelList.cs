using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace MGP.Location.API.Controllers.V1.Province.Response
{
    [SwaggerSchema("Respuesta a una solicitud para obtener todas las provincias")]
    public class GetAllProvincesResponseModelList
    {
        [SwaggerSchema("Lista de provincias")]
        public IEnumerable<GetAllProvincesResponseModel> Provinces { get; set; }
    }
}
