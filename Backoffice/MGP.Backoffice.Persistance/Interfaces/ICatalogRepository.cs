using MGP.Backoffice.Persistance.Data.Tables;
using MGP.Backoffice.Persistence.Data.Tables;
namespace MGP.Backoffice.Domain.Interface;

public interface ICatalogRepository
{
    Task<List<Area>> GetAreas();
    Task<List<Role>> GetRoles();
    Task<List<TicketType>> GetTicketByAreaAsync(string area);
    Task<List<UserStatus>> ListUserStatusAsync();
}