using MGP.Backoffice.Domain.DTOs;
using MGP.Backoffice.Persistance.DTOs;
namespace MGP.Backoffice.Application.UseCase.V1.ListAgents.ListByFilters;

public class ListAgentByFiltersResponse
{
    public Guid Id { get; set; }
    public string UserName { get; set; }
    public string EmployeeNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DocumentNumber { get; set; }
    public AreaData Area { get; set; }
    public UserStatusData UserStatus { get; set; }
}
