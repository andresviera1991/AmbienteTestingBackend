using MGP.Discapacidad.Persistance.DTOs.Catalog;
using System;
namespace MGP.Discapacidad.Persistance.DTOs.Ticket;
public class GetTicketSubeData
{
    public TicketData Ticket { get; set; }
    public string CudCertificateNumber { get; set; }
    public DateTime CudExpirationDate { get; set; }
    public CardPickupLocationsOptionsData CardPickupLocationsOptions { get; set; }
}
