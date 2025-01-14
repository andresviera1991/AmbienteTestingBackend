using Flunt.Notifications;
using MediatR;
using MGP.Authentication.CrossCutting.Enum;
using MGP.Authentication.CrossCutting.ResponseData;

namespace MGP.Authentication.Application.UseCase.V1.Password.ResetSendEmail
{
    public class ResetPasswordEmailRequest : Notifiable, IRequest<ResponseData<ResetPasswordEmailResponse, ResponseMessage>>
    {
        public string UserName { get; set; }
        public EmailType EmailTypeEnum { get; set; }

    }
}
