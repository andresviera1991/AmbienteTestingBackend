using Flunt.Notifications;
using MediatR;
using MGP.Backoffice.CrossCutting.ResponseData;


namespace MGP.Backoffice.Application.UseCase.V1.Auth.Logout
{
    public class LogoutRequest : Notifiable, IRequest<ResponseData<LogoutResponse, ResponseMessage>>
    {
        public string RefreshToken { get; set; }
    }
}
