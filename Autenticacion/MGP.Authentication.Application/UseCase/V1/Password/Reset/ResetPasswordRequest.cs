using Flunt.Notifications;
using MediatR;
using MGP.Authentication.CrossCutting.ResponseData;

namespace MGP.Authentication.Application.UseCase.V1.Password.Reset
{
    public class ResetPasswordRequest : Notifiable, IRequest<ResponseData<ResetPasswordResponse, ResponseMessage>>
    {
        public string Token { get; set; }

        public string NewPassword { get; set; }
    }
}
