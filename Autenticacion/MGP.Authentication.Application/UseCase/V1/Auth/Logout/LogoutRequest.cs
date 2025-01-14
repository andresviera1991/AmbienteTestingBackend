using Flunt.Notifications;
using MediatR;
using MGP.Authentication.CrossCutting.ResponseData;


namespace MGP.Authentication.Application.UseCase.V1.Authentication.Logout
{
    public class LogoutRequest : Notifiable, IRequest<ResponseData<LogoutResponse, ResponseMessage>>
    {
        public string RefreshToken { get; set; }
    }
}
