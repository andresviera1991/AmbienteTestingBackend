using Flunt.Notifications;
using MediatR;
using MGP.Authentication.CrossCutting.ResponseData;
using System;

namespace MGP.Authentication.Application.UseCase.V1.User.Delete
{
    public class DeleteUserRequest : Notifiable, IRequest<ResponseData<DeleteUserResponse, ResponseMessage>>
    {
        public string AccessToken { get; set; }
        public Guid UserId { get; set; }
    }
}
