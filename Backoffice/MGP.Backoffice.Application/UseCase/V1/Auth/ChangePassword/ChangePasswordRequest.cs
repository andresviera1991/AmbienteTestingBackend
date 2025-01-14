using Flunt.Notifications;
using MediatR;
using MGP.Backoffice.CrossCutting.ResponseData;

namespace MGP.Backoffice.Application.UseCase.V1.Auth.ChangePassword
{
    public class ChangePasswordRequest : Notifiable, IRequest<ResponseData<ChangePasswordResponse, ResponseMessage>>
    {
        public Guid AgentId { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
