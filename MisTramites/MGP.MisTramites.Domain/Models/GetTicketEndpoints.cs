namespace MGP.MisTramites.Domain.Models;
public class GetTicketEndpoints
{
    public Dictionary<string, UserType> Endpoints { get; set; }
}

public class UserType
{
    public Dictionary<string, string> USER { get; set; }
    public Dictionary<string, string> AGENT { get; set; }
}
