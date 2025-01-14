using MGP.Authentication.API.Controllers.Swagger.Messages;
using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Authentication.API.Controllers.Swagger.Authentication.Register
{
    [SwaggerSchema("Response to a request to create a user")]
    public class RegisterResponseModelExample
    {
        /// <summary>
        /// Example Code
        /// </summary>
        /// <example>201</example>
        [SwaggerSchema("Code")]
        public int Code { get; set; }

        public RegisterResponseModel Data { get; set; } = new RegisterResponseModel();

        /// <summary>
        /// List of error messages
        /// </summary>
        [SwaggerSchema("List of error messages, if any")]
        public VerifyEmail Message { get; set; }
    }
}
