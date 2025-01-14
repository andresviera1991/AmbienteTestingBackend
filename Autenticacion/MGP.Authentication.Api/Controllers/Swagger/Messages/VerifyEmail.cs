using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace MGP.Authentication.API.Controllers.Swagger.Messages
{
    public class VerifyEmail
    {
        /// <summary>
        /// Example list of error messages
        /// </summary>
        /// <example>["Verificar correo electronico"]</example>
        [SwaggerSchema("List of error messages")]
        public List<string> Message { get; set; }
    }
}
