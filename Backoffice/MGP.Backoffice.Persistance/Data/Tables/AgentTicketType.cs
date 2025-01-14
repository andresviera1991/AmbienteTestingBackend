using MGP.Backoffice.Persistance.Data.Tables.Base;
using MGP.Backoffice.Persistence.Data.Tables;
using System.ComponentModel.DataAnnotations.Schema;
namespace MGP.Backoffice.Persistance.Data.Tables;

public class AgentTicketType : EntityBaseGuid
{
    [ForeignKey("Agent")]
    public Guid AgentId { get; set; }
    public virtual User Agent { get; set; }

    [ForeignKey("TicketType")]
    public int TicketTypeId { get; set; }
    public virtual TicketType TicketType { get; set; }
}
