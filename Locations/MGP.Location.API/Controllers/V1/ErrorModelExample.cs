using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace MGP.Location.API.Controllers.V1
{
    public class ErrorModelExample
    {
        /// <example>500</example>
        [SwaggerSchema("Codigo Respuesta")]
        public int Code { get; set; }

        /// <example>null</example>
        [SwaggerSchema("Data")]
        public List<string> Data { get; set; }

        /// <summary>
        /// Example ErrorMessage containing a list of messages
        /// </summary>
        [SwaggerSchema("Mensaje de error")]
        public ErrorModel ErrorMessage { get; set; }
    }
}
