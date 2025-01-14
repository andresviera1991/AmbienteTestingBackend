using MGP.Discapacidad.Persistance.Data.Tables.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MGP.Discapacidad.Persistance.Data.Tables;

[Table("TicketSube")]
public class TicketSube : EntityBaseGuid
{
    public Ticket Ticket { get; set; }

    [Required]
    public int CardPickupId { get; set; }

    [Required]
    public string CudCertificateNumber { get; set; }

    [Required]
    public DateTime CudExpirationDate { get; set; }

    [ForeignKey("CardPickupId")]
    public CardPickupLocationsOptions CardPickupLocationsOptions { get; set; }
}
