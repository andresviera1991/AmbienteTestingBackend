using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;

namespace MGP.Discapacidad.API.Controllers.V1.Ticket.AgentTicket.Request;

[SwaggerSchema("Estructura de datos para la modificación del CUD de parte del agente",
Required = ["AssignedAgentId", "TicketStatusId", "CertificateExpansionOptionsId", "SignatureOptionsIs", "Certificate", "ExpiredCertificate", "LostCertificate", "HealthInsurance", "PaySlip", "DocumentComplete", "TicketId"])]
public class UpdateTicketCudRequestModel
{

    /// <example>11adb1c2-8364-4911-b363-5212becbdad3</example>
    [SwaggerSchema("Ticket Id")]
    public Guid TicketId { get; set; }

    /// <example>1</example>
    [SwaggerSchema("Ticket Status Id")]
    public int TicketStatusId { get; set; }

    /// <example>cristian.fer.mel@gmail.com</example>
    [SwaggerSchema("User Email")]
    public string UserEmail { get; set; }

    /// <example>1</example>
    [SwaggerSchema("Expansion option")] // NO AMPLIA
    public int CertificateExpansionOptionsId { get; set; }

    /// <example>1</example>
    [SwaggerSchema("Signature option")] // FIRMA POR SI MISMO
    public int SignatureOptionsId { get; set; }

    /// <example>true</example>
    [SwaggerSchema("Certificate")]
    public bool Certificate { get; set; }

    /// <example>false</example>
    [SwaggerSchema("Expired Certificate")]
    public bool ExpiredCertificate { get; set; }

    /// <example>false</example>
    [SwaggerSchema("Lost Certificate")]
    public bool LostCertificate { get; set; }

    /// <example>true</example>
    [SwaggerSchema("Health Insurance")]
    public bool HealthInsurance { get; set; }

    /// <example>true</example>
    [SwaggerSchema("PaySlip")]
    public bool PaySlip { get; set; }

    /// <example>false</example>
    [SwaggerSchema("Document Complete")]
    public bool DocumentComplete { get; set; }

    /// <example>null</example>
    [SwaggerSchema("Medical Committe Date")]
    public DateTime? MedicalCommitteDate { get; set; }

    /// <example>null</example>
    [SwaggerSchema("GDE Code")]
    public string GDECode { get; set; }

    [SwaggerSchema("Receives")]
    public List<UpdateDocumentStatusRequestModel> UpdateDocumentStatus { get; set; }
}
