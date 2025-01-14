using MGP.Backoffice.Domain.DTOs;
namespace MGP.Backoffice.Application.UseCase.V1.Catalog.ListUserStatus;

public class ListUserStatusResponse
{
    public List<UserStatusData> ListUserStatus { get; set; }
}
