using MGP.Backoffice.Persistance.Data.Tables.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGP.Backoffice.Persistance.Data.Tables;

[Table("TicketType")]
public class TicketType : EntityBase
{
    [ForeignKey("Area")]
    public int AreaId { get; set; }
    public virtual Area Area { get; set; }
}
