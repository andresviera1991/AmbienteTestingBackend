using Flunt.Notifications;
using MediatR;
using MGP.Authentication.CrossCutting.ResponseData;

namespace MGP.Authentication.Application.UseCase.V1.ResetPassword.ValidToken
{
    public class ValidateTokenRequest : Notifiable, IRequest<ResponseData<ValidateTokenResponse, ResponseMessage>>
    {
        public string Token { get; set; }
    }
}
