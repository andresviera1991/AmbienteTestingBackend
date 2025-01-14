using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MGP.Discapacidad.Persistance.Data.Tables.Base;
namespace MGP.Discapacidad.Persistance.Data.Tables;

[Table("TicketCud")]
public partial class TicketCud : EntityBaseGuid
{

    public Ticket Ticket { get; set; }

    /// <summary>
    /// ¿Necesita ampliar certificado? // 1 = no , 2 = si (motivo)
    /// </summary>
    #region Certificate Expansion Option
    [Required]
    public int CertificateExpansionOptionsId { get; set; }


    [ForeignKey("CertificateExpansionOptionsId")]
    [Required]
    public CertificateExpansionOptions CertificateExpansionOptions { get; set; }
    #endregion

    /// <summary>
    /// ¿Posee el certificado? 
    /// </summary>
    [Required]
    public bool Certificate { get; set; }

    /// <summary>
    /// ¿Certificado Venció? 
    /// </summary>
    [Required]
    public bool ExpiredCertificate { get; set; }

    /// <summary>
    /// ¿Perdida o robo?  
    /// </summary>
    [Required]
    public bool LostCertificate { get; set; }

    /// <summary>
    /// ¿Perdida o robo?  
    /// </summary>
    [Required]
    public bool HealthInsurance { get; set; }

    /// <summary>
    /// Posee recibo de haberes.
    /// </summary>
    [Required]
    public bool PaySlip { get; set; }

    /// <summary>
    /// ¿Firma por si mismo?
    /// </summary>
    #region Signature Option

    [Required]
    public int SignatureOptionId { get; set; }

    [ForeignKey("SignatureOptionId")]
    public virtual SignatureOption SignatureOption { get; set; }
    #endregion

    /// <summary>
    /// Documentación completa. 
    /// </summary>
    [Required]
    public bool DocumentComplete { get; set; }

    /// <summary>
    /// Fecha Junta Medica 
    /// </summary>
    public DateTime? MedicalCommitteDate { get; set; }

}
