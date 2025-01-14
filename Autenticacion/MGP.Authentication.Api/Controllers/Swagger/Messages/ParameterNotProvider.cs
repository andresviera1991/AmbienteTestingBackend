using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace MGP.Authentication.API.Controllers.Swagger.Messages
{
    public class ParameterNotProvider
    {
        /// <summary>
        /// Example list of error messages
        /// </summary>
        /// <example>["Uno o más parámetros no fueron proporcionados"]</example>
        [SwaggerSchema("List of error messages")]
        public List<string> Message { get; set; }
    }
}
