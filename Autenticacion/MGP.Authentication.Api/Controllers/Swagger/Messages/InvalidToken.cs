using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace MGP.Authentication.API.Controllers.Swagger.Messages
{
    public class InvalidToken
    {
        /// <summary>
        /// Example list of error messages
        /// </summary>
        /// <example>["Token Invalido"]</example>
        [SwaggerSchema("List of error messages")]
        public List<string> Message { get; set; }
    }
}
