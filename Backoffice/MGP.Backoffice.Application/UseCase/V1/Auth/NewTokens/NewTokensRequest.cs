using Flunt.Notifications;
using MediatR;
using MGP.Backoffice.CrossCutting.ResponseData;

namespace MGP.Backoffice.Application.UseCase.V1.Auth.NewTokens
{
    public class NewTokensRequest : Notifiable, IRequest<ResponseData<NewTokensResponse, ResponseMessage>>
    {
        public string RefreshToken { get; set; }
    }
}
