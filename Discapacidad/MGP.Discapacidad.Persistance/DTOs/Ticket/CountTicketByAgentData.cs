using MGP.Discapacidad.Persistance.DTOs.Catalog;
namespace MGP.Discapacidad.Persistance.DTOs.Ticket;
using MGP.Discapacidad.Client.DTOs.Response;
using System;
using System.Collections.Generic;
public class CountTicketByAgentData
{
    public Guid AgentId { get; set; }
    public AgentData Agent { get; set; }
    public List<TicketStatusQuantityData> TicketStatusQuantity { get; set; }
}

public class TicketStatusQuantityData
{
    public int Quantity { get; set; }
    public TicketStatusData TicketStatus { get; set; }
}