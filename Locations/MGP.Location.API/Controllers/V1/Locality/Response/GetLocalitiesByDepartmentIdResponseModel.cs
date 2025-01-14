using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Location.API.Controllers.V1.Locality.Response
{
    [SwaggerSchema("Respuesta a una solicitud para obtener la lista de localidades de un departamento")]
    public class GetLocalitiesByDepartmentIdResponseModel
    {
        /// <example>6357110</example>
        [SwaggerSchema("ID de localidad")]
        public int Id { get; set; }

        /// <example>Mar del Plata</example>
        [SwaggerSchema("Nombre de la localidad")]
        public string Name { get; set; }
    }
}
