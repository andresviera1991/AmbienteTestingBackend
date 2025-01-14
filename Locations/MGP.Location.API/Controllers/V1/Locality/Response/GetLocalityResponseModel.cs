using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Location.API.Controllers.V1.Locality.Response
{

    [SwaggerSchema("Respuesta a una solicitud para obtener la localidad")]
    public class GetLocalityResponseModel
    {
        /// <example>6357110</example>
        [SwaggerSchema("ID de localidad")]
        public long LocalityId { get; internal set; }

        /// <example>Mar del Plata</example>
        [SwaggerSchema("Nombre de la localidad")]
        public string LocalityName { get; internal set; }

        /// <example>6357</example>
        [SwaggerSchema("ID del departamento")]
        public long DepartmentId { get; internal set; }

        /// <example>General Pueyrredón</example>
        [SwaggerSchema("Nombre del departamento")]
        public string DepartmentName { get; internal set; }

        /// <example>6</example>
        [SwaggerSchema("ID de provincia")]
        public int ProvinceId { get; set; }

        /// <example>Buenos Aires</example>
        [SwaggerSchema("Nombre de la provincia")]
        public string ProvinceName { get; internal set; }
    }
}
