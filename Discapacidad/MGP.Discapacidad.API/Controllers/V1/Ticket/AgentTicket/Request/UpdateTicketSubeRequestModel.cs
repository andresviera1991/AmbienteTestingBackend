using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;

namespace MGP.Discapacidad.API.Controllers.V1.Ticket.AgentTicket.Request;

[SwaggerSchema("Estructura de datos para la modificación de SUBE de parte del agente",
Required = ["AssignedAgentId", "TicketStatusId", "CertificateExpansionOptionsId", "SignatureOptionsIs", "Certificate", "ExpiredCertificate", "LostCertificate", "HealthInsurance", "PaySlip", "DocumentComplete", "TicketId"])]
public class UpdateTicketSubeRequestModel
{

    /// <example>72eeb4b1-b696-4f9b-b908-1f1178865678</example>
    [SwaggerSchema("Ticket Id")]
    public Guid TicketId { get; set; }

    /// <example>1</example>
    [SwaggerSchema("Ticket Status Id")]
    public int TicketStatusId { get; set; }

    /// <example>cristian.fer.mel@gmail.com</example>
    [SwaggerSchema("User Email")]
    public string UserEmail { get; set; }

    /// <example>1</example>
    [SwaggerSchema("Card Locations Options")]
    public int CardPickupLocationsOptionsId { get; set; }

    /// <example>123</example>
    [SwaggerSchema("Cud Certificate Number")]
    public string CudCertificateNumber { get; set; }

    /// <example>null</example>
    [SwaggerSchema("GDE Code")]
    public string GDECode { get; set; }

    /// <example>2024-12-12</example>
    [SwaggerSchema("Cud Expiration Date")]
    public DateTime? CudExpirationDate { get; set; }
    public List<UpdateDocumentStatusRequestModel> UpdateDocumentStatus { get; set; }
}
