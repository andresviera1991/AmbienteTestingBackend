using MGP.Discapacidad.Persistance.Data.Tables;
using System;
using System.Collections.Generic;
using MGP.Discapacidad.Persistance.DTOs.Document;
using MGP.Discapacidad.Client.DTOs.Response;
namespace MGP.Discapacidad.Persistance.DTOs.Ticket;
public class TicketData
{
    public Guid Id { get; set; }
    public Guid? AssignedAgentId { get; set; }
    public Guid UserId { get; set; }
    public string TicketCode { get; set; }
    public virtual TicketStatus TicketStatus { get; set; }
    public virtual TicketType TicketType { get; set; }
    public DateTime CreationDate { get; set; }
    public virtual List<DocumentData> Documents { get; set; }
    public AgentData AgentData { get; set; }
    public UserData UserData { get; set; }
    public string GDECode { get; set; }
}
