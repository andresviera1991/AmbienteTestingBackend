using MGP.Authentication.Persistance.DTOs;
using System.Collections.Generic;
namespace MGP.Authentication.Application.UseCase.V1.User.List.ListUsers;

public class ListUsersByFiltersResponse
{
    public List<ResumeUserData> Users { get; set; }
}
