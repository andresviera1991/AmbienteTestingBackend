using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace MGP.Backoffice.Api.Controllers.Swagger
{
    public class InvalidToken
    {
        /// <summary>
        /// Example list of error messages
        /// </summary>
        /// <example>["Invalid Token"]</example>
        [SwaggerSchema("List of error messages")]
        public List<string> Message { get; set; }
    }
}
