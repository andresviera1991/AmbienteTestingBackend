using Flunt.Notifications;
using MediatR;
using MGP.Discapacidad.CrossCutting.ResponseData;
namespace MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.COUNT;

public class CountTicketsByAgentRequest : Notifiable, IRequest<ResponseData<CountTicketsByAgentResponse,ResponseMessage>>
{

}
