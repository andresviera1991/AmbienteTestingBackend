using System;
using System.Collections.Generic;
namespace MGP.Authentication.Application.UseCase.V1.User.List.ListUserIds;

public class ListUserIdsByFiltersResponse
{
    public List<Guid> UserIds { get; set; }
}
