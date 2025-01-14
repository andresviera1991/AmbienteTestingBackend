using Flunt.Notifications;
using MediatR;
using MGP.Authentication.CrossCutting.ResponseData;
using System;

namespace MGP.Authentication.Application.UseCase.V1.Password.Change
{
    public class ChangePasswordRequest : Notifiable, IRequest<ResponseData<ChangePasswordResponse, ResponseMessage>>
    {
        public Guid UserId { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
