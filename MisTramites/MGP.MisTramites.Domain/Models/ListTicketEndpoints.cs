namespace MGP.MisTramites.Domain.Models;
public class ListTicketEndpoints
{
    public List<string> ListTicketUser { get; set; }
    public Dictionary<string, List<string>> ListTicketAgent { get; set; }
}
