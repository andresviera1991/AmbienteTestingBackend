using Flunt.Notifications;
using MediatR;
using MGP.Authentication.CrossCutting.ResponseData;
using System;

namespace MGP.Authentication.Application.UseCase.V1.User.GetUser
{
    public class GetUserRequest : Notifiable, IRequest<ResponseData<GetUserResponse, ResponseMessage>>
    {
        public string AccessToken { get; set; }
        public Guid UserId { get; set; }
    }
}
