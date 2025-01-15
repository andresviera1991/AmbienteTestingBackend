using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace MGP.Notifications.API.Controllers.Swagger.Response.Message
{
    public class ParameterNotProvider
    {
        /// <summary>
        /// Example list of error messages
        /// </summary>
        /// <example>["The input parameter was not provided"]</example>
        [SwaggerSchema("List of error messages")]
        public List<string> Message { get; set; }
    }
}
