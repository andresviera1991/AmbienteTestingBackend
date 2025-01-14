namespace MGP.MisTramites.Client.DTOs.Response.ListTicket;

public class TicketData
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public UserData UserData { get; set; }
    public AgentData AgentData { get; set; }
    public string TicketCode { get; set; }
    public TicketStatusData TicketStatus { get; set; }
    public TicketTypeData TicketType { get; set; }
    public string MicroserviceName { get; set; }
    public DateTime CreationDate { get; set; }
}