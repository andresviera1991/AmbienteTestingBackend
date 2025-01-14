using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace MGP.Location.API.Controllers.V1.Street.Response
{
    [SwaggerSchema("Respuesta a una solicitud para obtener todas las calles de una localidad")]
    public class GetStreetsByNameResponseModelList
    {
        [SwaggerSchema("Lista de calles")]
        public IEnumerable<GetStreetsByNameResponseModel> Streets { get; set; }
    }
}
