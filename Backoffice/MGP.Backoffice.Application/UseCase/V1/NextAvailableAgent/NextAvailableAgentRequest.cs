using Flunt.Notifications;
using MediatR;
using MGP.Backoffice.CrossCutting.ResponseData;

namespace MGP.Backoffice.Application.UseCase.V1.NextAvailableAgent
{
    public class NextAvailableAgentRequest : Notifiable, IRequest<ResponseData<NextAvailableAgentResponse, ResponseMessage>>
    {
        public string Area { get; set; }
        public string TicketType { get; set; }
    }
}
