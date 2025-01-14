using Flunt.Notifications;
using MediatR;
using MGP.MisTramites.Client.DTOs.Response.ListTicket;
using MGP.MisTramites.CrossCutting.ResponseData;
using MGP.MisTramites.Domain.DTOs;
namespace MGP.MisTramites.Application.UseCase.V1.Agent.ListTickets;
public class ListTicketAgentRequest : Notifiable, IRequest<ResponseData<TicketDataModel, ResponseMessage>>
{
    public string ServiceName { get; set; }
    public string FullName { get; set; }
    public string DocumentNumber { get; set; }
    public string TicketCode { get; set; }
    public int? TicketTypeId { get; set; }
    public int? TicketStatusId { get; set; }
    public bool AssignedToMe { get; set; }
    public Guid? AgentId { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
}
