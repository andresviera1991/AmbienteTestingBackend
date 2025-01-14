using MGP.Discapacidad.Persistance.Data.Tables.Base;
using System.ComponentModel.DataAnnotations.Schema;
namespace MGP.Discapacidad.Persistance.Data.Tables;

[Table("TicketParking")]
public class TicketParking : EntityBaseGuid
{
    public Ticket Ticket { get; set; }

}
