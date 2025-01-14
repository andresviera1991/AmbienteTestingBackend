using Flunt.Notifications;
using MediatR;
using MGP.Backoffice.CrossCutting.ResponseData;

namespace MGP.Backoffice.Application.UseCase.V1.Auth.Login
{
    public class LoginRequest : Notifiable, IRequest<ResponseData<LoginResponse, ResponseMessage>>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
