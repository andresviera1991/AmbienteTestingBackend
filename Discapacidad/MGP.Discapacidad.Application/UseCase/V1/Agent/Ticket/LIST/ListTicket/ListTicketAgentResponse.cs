using MGP.Discapacidad.Persistance.DTOs.Ticket;

namespace MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.LIST.ListTicket;

public class ListTicketAgentResponse
{
    public int CountTickets { get; set; }

    public int PageNumber { get; set; }

    public ListTicketData[] ListTicketData { get; set; }
}
