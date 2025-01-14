using Flunt.Notifications;
using MediatR;
using MGP.Authentication.CrossCutting.ResponseData;
using System.Collections.Generic;
namespace MGP.Authentication.Application.UseCase.V1.Catalog.UserStatus;

public class UserStatusRequest : Notifiable, IRequest<ResponseData<List<UserStatusResponse>, ResponseMessage>>
{
}
