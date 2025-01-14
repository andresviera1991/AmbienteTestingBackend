using MGP.Backoffice.Domain.DTOs;

namespace MGP.Backoffice.Persistance.DTOs;
public class UserData
{
    public Guid Id { get; set; }
    public string UserName { get; set; }

    public string EmployeeNumber { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string DocumentNumber { get; set; }

    public string Email { get; set; }
    public string Roles { get; set; }
    public AreaData Area { get; set; }

    public UserStatusData UserStatus { get; set; }

    public List<TicketTypeData> ManagedTicketTypes { get; set; }
}
