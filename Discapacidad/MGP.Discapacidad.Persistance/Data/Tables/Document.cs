using MGP.Discapacidad.Persistance.Data.Tables.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MGP.Discapacidad.Persistance.Data.Tables;

[Table("Document")]
public partial class Document : EntityBaseGuid
{
    [Required]
    public string DocumentImage { get; set; }
    [Required]
    public Guid TicketId { get; set; }

    #region Document Status

    [Required]
    public int DocumentStatusId { get; set; }

    [ForeignKey("DocumentStatusId")]
    public virtual DocumentStatus DocumentStatus { get; set; }

    #endregion

    #region Document Type
    [Required]
    public int DocumentTypeId { get; set; }

    [ForeignKey("DocumentTypeId")]
    public virtual DocumentType DocumentType { get; set; }

    #endregion
}
