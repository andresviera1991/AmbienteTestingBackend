using Flunt.Notifications;
using MediatR;
using MGP.MisTramites.CrossCutting.ResponseData;

namespace MGP.MisTramites.Application.UseCase.V1.Agent.GetTicket;

public class GetTicketAgentRequest : Notifiable, IRequest<ResponseData<Object,ResponseMessage>>
{
    public string ServiceName { get; set; }
    public Guid TicketId { get; set; }
    public int TicketTypeId { get; set; }
}
