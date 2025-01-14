using MGP.Backoffice.Api.Controllers.Swagger;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace MGP.Backoffice.Api.Controllers.Auth.Response
{
    [SwaggerSchema("Response to a request to create person")]
    public class RegisterResponseModel400
    {
        /// <summary>
        /// Example Code
        /// </summary>
        /// <example>400</example>
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
        public ParameterNotProvider ErrorMessage { get; set; }
    }
}
