using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace MGP.Discapacidad.API.Controllers.V1.Ticket.UserTicket.Request;

[SwaggerSchema("Data structure containing request details for create a ticket CUD",
    Required = new string[] { "Certificate", "ExpiredCertificate", "CertificateExpansionOptionsId"
    , "LostCertificate", "HealthInsurance", "PaySlip", "SignatureOptionId", "Documents"})]
public class CreateTicketCudRequestModel
{

    /// <example>true</example>
    [SwaggerSchema("Indicates if the person has any certificate")]
    public bool? Certificate { get; set; }

    /// <example>false</example>
    [SwaggerSchema("Indicates whether the certificate has expired.")]
    public bool? ExpiredCertificate { get; set; }

    /// <example>1</example> // Cambié el valor de ejemplo a 1 para mayor claridad.
    [SwaggerSchema("Indicates the ID of the selected certificate expansion option. Use 1 for 'No expansion' or other values for specific reasons.")]
    public int? CertificateExpansionOptionsId { get; set; }

    /// <example>false</example> // Ejemplo agregado para claridad.
    [SwaggerSchema("Indicates whether the certificate has been lost. True if the certificate is lost, false otherwise.")]
    public bool? LostCertificate { get; set; }

    /// <example>false</example> // Ejemplo agregado para claridad.
    [SwaggerSchema("Indicates whether the health insurance option is selected. True if health insurance is included, false otherwise.")]
    public bool? HealthInsurance { get; set; }

    /// <example>false</example>
    [SwaggerSchema("Indicate if the person has a payslip.")]
    public bool? PaySlip { get; set; }

    /// <example>1</example>
    [SwaggerSchema("Indicate if the person signs on their own, with assistance, or through a third party.")]
    public int? SignatureOptionId { get; set; }

    [SwaggerSchema("Receives the TypeDocument and the URL of the DNI Front, Back, and Medical History file.")]
    public List<DocumentRequestModel> Documents { get; set; }
}
