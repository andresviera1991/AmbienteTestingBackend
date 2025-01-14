using MGP.Backoffice.Persistance.Data.Tables;

namespace MGP.Backoffice.Persistance.Interfaces
{
    public interface IMenuRepository
    {
        Task<List<Menu>> ListMenusAsync(Guid roleId, int areaId);
        Task<List<Menu>> ListMenusAsync(Guid roleId);
    }
}
