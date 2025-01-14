using MGP.Backoffice.Domain.DTOs;
namespace MGP.Backoffice.Application.UseCase.V1.Catalog.GetTicketByArea;

public class GetTicketByAreaResponse
{
    public List<TicketTypeData> TicketTypes { get; set; }
}
