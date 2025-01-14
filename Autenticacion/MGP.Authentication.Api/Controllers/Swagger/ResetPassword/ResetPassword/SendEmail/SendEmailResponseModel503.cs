using MGP.Authentication.API.Controllers.Swagger.Messages;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace MGP.Authentication.API.Controllers.Swagger.ResetPassword.ResetPassword.SendEmail
{
    public class SendEmailResponseModel503
    {
        /// <summary>
        /// Example Code
        /// </summary>
        /// <example>503</example>
        [SwaggerSchema("Code")]
        public int Code { get; set; }

        /// <summary>
        /// Example Data list containing strings
        /// </summary>
        /// <example>null</example>
        [SwaggerSchema("List of strings representing data")]
        public List<string> Data { get; set; }

        /// <summary>
        /// Example ErrorMessage containing a list of messages
        /// </summary>
        [SwaggerSchema("Error message")]
        public ServiceUnavailable ErrorMessage { get; set; }
    }
}
