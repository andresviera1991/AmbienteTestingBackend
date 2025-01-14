using MGP.Discapacidad.Persistance.DTOs.Ticket;
using System.Collections.Generic;
namespace MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.COUNT;

public class CountTicketsByAgentResponse
{ 
    public List<CountTicketByAgentData> CountTicketData { get; set; }
}
