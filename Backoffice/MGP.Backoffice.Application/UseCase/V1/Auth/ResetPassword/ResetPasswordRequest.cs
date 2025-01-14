using Flunt.Notifications;
using MediatR;
using MGP.Backoffice.CrossCutting.ResponseData;

namespace MGP.Backoffice.Application.UseCase.V1.Auth.ResetPassword
{
    public class ResetPasswordRequest : Notifiable, IRequest<ResponseData<ResetPasswordResponse, ResponseMessage>>
    {
        public string EmployeeNumber { get; set; }
    }
}
