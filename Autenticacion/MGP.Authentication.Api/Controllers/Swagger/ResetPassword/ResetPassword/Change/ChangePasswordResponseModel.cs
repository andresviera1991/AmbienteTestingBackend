using MGP.Authentication.Application.UseCase.V1.Password.Change;
using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Authentication.API.Controllers.Swagger.ResetPassword.ResetPassword.Change
{
    public class ChangePasswordResponseModel
    {
        /// <summary>
        /// Example Code
        /// </summary>
        /// <example>200</example>
        [SwaggerSchema("Response Code")]
        public int Code { get; set; }

        /// <summary>
        /// Example Code
        /// </summary>
        /// <example>True</example>
        [SwaggerSchema("Login Response Data")]
        public ChangePasswordResponse Data { get; set; }

        /// <summary>
        /// List of error messages
        /// </summary>
        /// <example>null</example>
        [SwaggerSchema("List of error messages, if any")]
        public string Message { get; set; }
    }
}
