
using Flunt.Notifications;
using MediatR;
using MGP.Authentication.CrossCutting.ResponseData;
using System.Collections.Generic;
using System;

namespace MGP.Authentication.Application.UseCase.V1.User.List.ListUserIds;
public class ListUserIdsByFiltersRequest : Notifiable, IRequest<ResponseData<List<Guid>, ResponseMessage>>
{
    public string FullName { get; set; }
    public string DocumentNumber { get; set; }
}
