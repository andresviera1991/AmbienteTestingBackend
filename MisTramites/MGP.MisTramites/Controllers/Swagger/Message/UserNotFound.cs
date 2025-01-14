using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace MGP.MisTramites.API.Controllers.Swagger.Response.Message
{
    public class UserNotFound
    {
        /// <summary>
        /// Example list of error messages
        /// </summary>
        /// <example>["doesn't exist."]</example>
        [SwaggerSchema("List of error messages")]
        public List<string> Message { get; set; }
    }
}
