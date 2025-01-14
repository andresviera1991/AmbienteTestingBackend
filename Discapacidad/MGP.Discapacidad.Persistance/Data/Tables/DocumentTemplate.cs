using MGP.Discapacidad.Persistance.Data.Tables.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MGP.Discapacidad.Persistance.Data.Tables;

public class DocumentTemplate : EntityBaseGuid
{
    [Required]
    public string DocumentPath { get; set; }

    [Required]
    [MaxLength(500)]
    public string Name { get; set; }

    [Required]
    [MaxLength(500)]
    public string Information { get; set; }
    
    [Required]
    public bool Status { get; set; }

    #region Document Type
    [Required]
    public int TicketTypeId { get; set; }

    [ForeignKey("TicketTypeId")]
    public TicketType TicketType { get; set; }
    #endregion

}
