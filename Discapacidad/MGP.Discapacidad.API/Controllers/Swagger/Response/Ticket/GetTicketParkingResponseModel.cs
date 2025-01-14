using MGP.Discapacidad.Persistance.DTOs.Ticket;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace MGP.Discapacidad.API.Controllers.SwaggerExample.Response.Ticket
{
    public class GetTicketParkingResponseModel
    {
        /// <summary>
        /// Example Code
        /// </summary>
        /// <example>200</example>
        [SwaggerSchema("Code")]
        public int Code { get; set; }

        /// <summary>
        /// Example Data list containing strings
        /// </summary>
        /// <example></example>
        [SwaggerSchema("List of strings representing data")]
        public List<GetTicketParkingData> Data { get; set; } = new List<GetTicketParkingData>();

        /// <summary>
        /// Example list of error messages
        /// </summary>
        /// <example>null</example>
        [SwaggerSchema("List of error messages")]
        public string ErrorMessage { get; set; }
    }
}
