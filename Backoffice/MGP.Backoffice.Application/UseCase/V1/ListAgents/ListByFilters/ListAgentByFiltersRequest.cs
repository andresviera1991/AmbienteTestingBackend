using Flunt.Notifications;
using MediatR;
using MGP.Backoffice.CrossCutting.ResponseData;

namespace MGP.Backoffice.Application.UseCase.V1.ListAgents.ListByFilters;

public class ListAgentByFiltersRequest : Notifiable, IRequest<ResponseData<ListAgentByFiltersListResponse, ResponseMessage>>
{
    public string Role { get; set; }
    public string Area { get; set; }
    public string EmployeeNumber { get; set; }
    public string FullName { get; set; }
    public string DocumentNumber { get; set; }
    public int? UserStatusId { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
}
