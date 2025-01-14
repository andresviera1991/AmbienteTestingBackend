using MediatR;
using MGP.Backoffice.CrossCutting.ResponseData;
using MGP.Backoffice.Domain.DTOs;
namespace MGP.Backoffice.Application.UseCase.V1.UpdateAgent;

public class UpdateAgentRequest : IRequest<ResponseData<UpdateAgentResponse, ResponseMessage>>
{
    public Guid AgentId { get; set; }
    public string EmployeeNumber { get; set; }
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DocumentNumber { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
    public int? AreaId { get; set; }
    public int? UserStatusId { get; set; }
    public List<TicketTypeData> ManagedTicketTypes { get; set; }

}
