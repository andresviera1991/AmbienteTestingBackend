using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Location.API.Controllers.V1.Province.Response
{
    [SwaggerSchema("Respuesta a una solicitud para obtener todas las provincias")]
    public class GetAllProvincesResponseModel
    {
        /// <example>6</example>
        [SwaggerSchema("ID de provincia")]
        public int Id { get; set; }

        /// <example>Buenos Aires</example>
        [SwaggerSchema("Nombre de la provincia")]
        public string Name { get; set; }
    }
}
