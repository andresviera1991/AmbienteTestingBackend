using Flunt.Notifications;
using MediatR;
using MGP.Authentication.CrossCutting.ResponseData;

namespace MGP.Authentication.Application.UseCase.V1.Authentication.Login
{
    public class LoginRequest : Notifiable, IRequest<ResponseData<LoginResponse, ResponseMessage>>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
