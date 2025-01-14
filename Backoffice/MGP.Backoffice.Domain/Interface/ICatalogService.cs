using MGP.Backoffice.Domain.DTOs;
using MGP.Backoffice.Persistance.DTOs;

namespace MGP.Backoffice.Domain.Interface;
public interface ICatalogService
{
    Task<List<AreaData>> GetAreasAsync();
    Task<List<RoleData>> GetRolesAsync();
    Task<List<TicketTypeData>> GetTicketByAreaAsync(string area);
    Task<List<UserStatusData>> ListUserStatusAsync();
}
