using MGP.Backoffice.Api.Controllers.Swagger;
using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Backoffice.Api.Controllers.Auth.Response
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
