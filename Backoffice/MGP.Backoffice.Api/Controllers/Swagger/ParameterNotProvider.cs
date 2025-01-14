using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace MGP.Backoffice.Api.Controllers.Swagger
{
    public class ParameterNotProvider
    {
        /// <summary>
        /// Example list of error messages
        /// </summary>
        /// <example>["One or more parameters were not provided"]</example>
        [SwaggerSchema("List of error messages")]
        public List<string> Message { get; set; }
    }
}
