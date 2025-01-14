using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace MGP.Backoffice.Api.Controllers.Swagger
{
    public class UserNotExists
    {
        /// <summary>
        /// Example list of error messages
        /// </summary>
        /// <example>["User doesn't exists."]</example>
        [SwaggerSchema("List of error messages")]
        public List<string> Message { get; set; }
    }
}
