namespace MGP.MisTramites.Client.DTOs.Response.ListTicket;
public class UserData
{
    public PersonData Person { get; set; }
}

public class PersonData()
{
    public string LastName { get; set; }
    public string Name { get; set; }
    public string DocumentNumber { get; set; }
}