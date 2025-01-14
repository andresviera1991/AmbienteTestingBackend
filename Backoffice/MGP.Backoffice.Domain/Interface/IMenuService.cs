using MGP.Backoffice.Domain.DTOs;

namespace MGP.Backoffice.Domain.Interface
{
    public interface IMenuService
    {
        Task<List<MenuDto>> ListMenusAsync(AreaRolData areaRolData);
    }
}
