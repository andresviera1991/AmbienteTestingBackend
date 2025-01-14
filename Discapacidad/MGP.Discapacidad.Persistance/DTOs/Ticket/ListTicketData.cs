using MGP.Discapacidad.Client.DTOs.Response;
using MGP.Discapacidad.Persistance.DTOs.Catalog;
using System;
namespace MGP.Discapacidad.Persistance.DTOs.Ticket;
public class ListTicketData
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid AssignedAgentId { get; set; }
    public UserData UserData { get; set; }
    public AgentData AgentData { get; set; }
    public string TicketCode { get; set; }
    public virtual TicketStatusData TicketStatus { get; set; }
    public virtual TicketTypeData TicketType { get; set; }
    public bool DocumentComplete { get; set; }
    public DateTime CreationDate { get; set; }
    public string MicroserviceName { get; set; } = "DISCAPACIDAD";
    public string GDECode { get; set; }
}
