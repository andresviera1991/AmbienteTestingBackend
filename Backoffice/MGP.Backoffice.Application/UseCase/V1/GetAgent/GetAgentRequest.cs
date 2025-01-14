using Flunt.Notifications;
using MediatR;
using MGP.Backoffice.CrossCutting.ResponseData;

namespace MGP.Backoffice.Application.UseCase.V1.GetAgent
{
    public class GetAgentRequest : Notifiable, IRequest<ResponseData<GetAgentResponse, ResponseMessage>>
    {
        public Guid AgentId { get; set; }
    }
}
