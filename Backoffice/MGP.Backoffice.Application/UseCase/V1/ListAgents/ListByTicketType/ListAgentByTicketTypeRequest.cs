using Flunt.Notifications;
using MediatR;
using MGP.Backoffice.CrossCutting.ResponseData;

namespace MGP.Backoffice.Application.UseCase.V1.ListAgents.ListByTicketType;

public class ListAgentByTicketTypeRequest : Notifiable, IRequest<ResponseData<ListAgentByTicketTypeResponse, ResponseMessage>>
{
    public int? TicketTypeId { get; set; } 
}
