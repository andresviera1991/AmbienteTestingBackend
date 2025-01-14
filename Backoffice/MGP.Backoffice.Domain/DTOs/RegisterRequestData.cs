namespace MGP.Backoffice.Domain.DTOs;

public class RegisterRequestData
{
    public string UserName { get; set; }
    public string EmployeeNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DocumentNumber { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
    public int AreaId { get; set; }
    public List<TicketTypeData> ManagedTicketTypes { get; set; }

}
