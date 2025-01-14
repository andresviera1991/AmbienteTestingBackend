using MGP.Authentication.Application.UseCase.V1.Password.ResetSendEmail;
using Swashbuckle.AspNetCore.Annotations;

namespace MGP.Authentication.API.Controllers.Swagger.ResetPassword.ResetPassword.SendEmail
{
    public class SendEmailResponseModel
    {
        /// <summary>
        /// Example Code
        /// </summary>
        /// <example>200</example>
        [SwaggerSchema("Response Code")]
        public int Code { get; set; }

        /// <summary>
        /// Data containing the JWT Token
        /// </summary>
        /// <example>["Verify Email"]</example>
        [SwaggerSchema("Login Response Data")]
        public ResetPasswordEmailResponse Data { get; set; }

        /// <summary>
        /// List of error messages
        /// </summary>
        /// <example>null</example>
        [SwaggerSchema("List of error messages, if any")]
        public string Message { get; set; }
    }
}
