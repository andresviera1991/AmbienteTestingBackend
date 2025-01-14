using MGP.Audit.API.Controllers.Swagger.Response.Message;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace MGP.Audit.API.Controllers.Swagger.Response
{

    public class ResponseModel404
        {
            /// <summary>
            /// Example Code
            /// </summary>
            /// <example>404</example>
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
            public UserNotFound ErrorMessage { get; set; }
        }

    }

