using MGP.Discapacidad.Persistance.Data.Tables.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MGP.Discapacidad.Persistance.Data.Tables;

[Table("Ticket")]
public partial class Ticket : EntityBaseGuid
{
    [Required]
    public Guid UserId { get; set; }

    [Required]
    [MaxLength(256)]
    public string TicketCode { get; set; }

    public Guid? AgentId { get; set; }
    public Guid? AssignedAgentId { get; set; }

    [MaxLength(256)]
    public string GDECode { get; set; }

    #region Ticket Status
    [Required]
    public int TicketStatusId { get; set; }

    [ForeignKey("TicketStatusId")]
    public virtual TicketStatus TicketStatus { get; set; }

    #endregion

    #region Ticket Type
    [Required]
    public int TicketTypeId { get; set; }

    [ForeignKey("TicketTypeId")]
    public virtual TicketType TicketType { get; set; }
    #endregion       

    public virtual List<Document> Documents { get; set; }

}