using Flunt.Notifications;
using MediatR;
using MGP.Backoffice.CrossCutting.ResponseData;

namespace MGP.Backoffice.Application.UseCase.V1.UpdateAgentLeave
{
    public class UpdateAgentLeaveRequest : Notifiable, IRequest<ResponseData<UpdateAgentLeaveResponse, ResponseMessage>>
    {
        public Guid Id { get; set; }
        public Guid AgentId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
