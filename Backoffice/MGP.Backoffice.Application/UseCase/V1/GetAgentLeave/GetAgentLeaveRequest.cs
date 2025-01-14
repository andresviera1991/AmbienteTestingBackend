using Flunt.Notifications;
using MediatR;
using MGP.Backoffice.CrossCutting.ResponseData;

namespace MGP.Backoffice.Application.UseCase.V1.GetAgentLeave
{
    public class GetAgentLeaveRequest : Notifiable, IRequest<ResponseData<GetAgentLeaveListResponse, ResponseMessage>>
    {
        public Guid AgentId { get; set; }
    }
}
