using MGP.Backoffice.Domain.DTOs;
namespace MGP.Backoffice.Application.UseCase.V1.Catalog.GetRoles;

public class GetRolesResponse
{
    public List<RoleData> Roles { get; set; }
}
