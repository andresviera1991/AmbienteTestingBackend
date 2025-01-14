using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.CUD.Create;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace MGP.Discapacidad.API.Controllers.SwaggerExample.Response.Ticket
{
    public class CreateTicketCudResponseModel
    {
        /// <summary>
        /// Example Code
        /// </summary>
        /// <example>201</example>
        [SwaggerSchema("Code")]
        public int Code { get; set; }

        /// <summary>
        /// Example Data list containing strings
        /// </summary>
        [SwaggerSchema("List of strings representing data")]
        public List<CreateTicketCudResponse> Data { get; set; } = new List<CreateTicketCudResponse>();

        /// <summary>
        /// Example list of error messages
        /// </summary>
        /// <example>null</example>
        [SwaggerSchema("List of error messages")]
        public string ErrorMessage { get; set; }
    }
}
