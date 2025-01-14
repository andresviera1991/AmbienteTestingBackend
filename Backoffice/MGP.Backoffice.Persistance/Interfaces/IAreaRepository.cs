using MGP.Backoffice.Persistance.Data.Tables;
namespace MGP.Backoffice.Persistance.Interfaces;
public interface IAreaRepository
{
    Task<bool> AreaExistsAsync(int areaId);
    Task<Area> FindByIdAsync(int areaId);
    Task<Area> FindByNameAsync(string areaName);
}
