using MGP.Authentication.Application.UseCase.V1.ResetPassword.ValidToken;
using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Authentication.API.Controllers.Swagger.ResetPassword.ResetPassword.ValidateToken
{
    public class ValidateTokenResponseModel
    {
        /// <summary>
        /// Example Code
        /// </summary>
        /// <example>200</example>
        [SwaggerSchema("Response Code")]
        public int Code { get; set; }

        public ValidateTokenResponse Data { get; set; }

        /// <summary>
        /// List of error messages
        /// </summary>
        /// <example>null</example>
        [SwaggerSchema("List of error messages, if any")]
        public string Message { get; set; }
    }
}
