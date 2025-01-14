using Flunt.Notifications;
using MediatR;
using MGP.Authentication.Application.UseCase.V1.User.Update.Request;
using MGP.Authentication.CrossCutting.ResponseData;
using MGP.Authentication.Persistance.DTOs;
using System;

namespace MGP.Authentication.Application.UseCase.V1.User.Update
{
    public class UpdateUserRequest : Notifiable, IRequest<ResponseData<UserData, ResponseMessage>>
    {
        public string AccessToken {get; set;}
        public int? UserStatusId { get; set; }
        public Guid? UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public PersonUpdateUserRequest Person { get; set; }
    }
}
