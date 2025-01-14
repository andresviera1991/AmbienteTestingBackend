using Flunt.Notifications;
using MediatR;
using MGP.Authentication.CrossCutting.ResponseData;

namespace MGP.Authentication.Application.UseCase.V1.Authentication.RefreshSessionToken
{
    public class NewSessionTokenRequest : Notifiable, IRequest<ResponseData<NewSessionTokenResponse,ResponseMessage>>
    {
        public string RefreshToken { get; set; }
    }
}
