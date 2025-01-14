using Flunt.Notifications;
using MediatR;
using MGP.Authentication.CrossCutting.ResponseData;

namespace MGP.Authentication.Application.UseCase.V1.Authentication.ValidateUser
{
    public class ValidateRegisterRequest : Notifiable, IRequest<ResponseData<ValidateRegisterResponse, ResponseMessage>>
    {
        public string Token { get; set; }
    }
}
