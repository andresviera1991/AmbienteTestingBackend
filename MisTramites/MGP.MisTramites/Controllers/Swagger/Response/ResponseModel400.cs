using MGP.MisTramites.API.Controllers.Swagger.Response.Message;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace MGP.MisTramites.API.Controllers.SwaggerExample.Response
{
    [SwaggerSchema("Response to a request to create person")]
    public class ResponseModel400
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
