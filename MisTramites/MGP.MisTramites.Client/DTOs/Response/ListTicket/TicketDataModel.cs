namespace MGP.MisTramites.Client.DTOs.Response.ListTicket;

public class TicketDataModel
{
    public int CountTickets { get; set; }
    public int PageNumber { get; set; }
    public List<TicketData> ListTicketData { get; set; }
}
