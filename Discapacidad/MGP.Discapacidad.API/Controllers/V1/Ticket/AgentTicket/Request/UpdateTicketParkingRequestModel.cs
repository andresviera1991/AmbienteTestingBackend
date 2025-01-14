using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;

namespace MGP.Discapacidad.API.Controllers.V1.Ticket.AgentTicket.Request
{
    public class UpdateTicketParkingRequestModel
    {
        /// <example>72eeb4b1-b696-4f9b-b908-1f1178865678</example>
        [SwaggerSchema("Ticket Id")]
        public Guid TicketId { get; set; }

        /// <example>cristian.fer.mel@gmail.com</example>
        [SwaggerSchema("User Email")]
        public string UserEmail { get; set; }

        /// <example>null</example>
        [SwaggerSchema("GDE Code")]
        public string GDECode { get; set; }

        /// <example>1</example>
        [SwaggerSchema("Ticket Status Id")]
        public int TicketStatusId { get; set; }
        public List<UpdateDocumentStatusRequestModel> UpdateDocumentStatus { get; set; }
    }
}
