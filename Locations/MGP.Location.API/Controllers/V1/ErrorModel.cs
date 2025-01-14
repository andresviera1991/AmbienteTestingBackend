using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace MGP.Location.API.Controllers.V1
{
    [SwaggerSchema("Respuesta de error")]
    public class ErrorModel
    {
        /// <example>["Error en el servidor", "No se pudo conectar a la base de datos"]</example>
        [SwaggerSchema("Mensaje de error")]
        public List<string> Message { get; set; }
    }
}
