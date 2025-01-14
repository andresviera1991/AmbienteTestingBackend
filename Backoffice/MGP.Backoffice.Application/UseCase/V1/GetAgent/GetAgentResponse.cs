using MGP.Backoffice.Domain.DTOs;
using MGP.Backoffice.Persistance.DTOs;
namespace MGP.Backoffice.Application.UseCase.V1.GetAgent;

public class GetAgentResponse
{
    public Guid Id { get; set; }
    public string UserName { get; set; }
    public string EmployeeNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DocumentNumber { get; set; }
    public string Email { get; set; }
    public string Roles { get; set; }
    public UserStatusData UserStatus { get; set; }
    public AreaData Area { get; set; }
    public List<TicketTypeData> ManagedTicketTypes { get; set; }
}
