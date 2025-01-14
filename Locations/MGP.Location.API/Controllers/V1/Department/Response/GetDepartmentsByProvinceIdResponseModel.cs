using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Location.API.Controllers.V1.Department.Response
{
    [SwaggerSchema("Respuesta a una solicitud para obtener la lista de departamentos de una provincia")]
    public class GetDepartmentsByProvinceIdResponseModel
    {
        /// <example>6357</example>
        [SwaggerSchema("ID de departamento")]
        public int Id { get; set; }

        /// <example>General Pueyrredón</example>
        [SwaggerSchema("Nombre del departamento")]
        public string Name { get; set; }
    }
}
