using MGP.Backoffice.Persistance.Data.Tables;
using MGP.Backoffice.Persistance.Interfaces;
using MGP.Backoffice.Persistence.Data.Tables;
using Microsoft.EntityFrameworkCore;

namespace MGP.Backoffice.Persistance
{
    public class MenuRepository : IMenuRepository
    {
        private readonly MyDbContext _dbContext;

        public MenuRepository(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Menu>> ListMenusAsync(Guid roleId, int areaId)
        {
            var menus = await _dbContext.Set<MenuByAreaAndRole>()
                                .Where(m => m.RoleId == roleId && m.AreaId == areaId)
                                .Select(m => m.Menu) 
                                .ToListAsync();

            var menuDictionary = menus.ToDictionary(m => m.Id);

            foreach (var menu in menus)
            {
                if (menu.ParentMenuId.HasValue && menuDictionary.ContainsKey(menu.ParentMenuId.Value))
                {
                    menuDictionary[menu.ParentMenuId.Value].ChildMenus.Add(menu);
                }
            }

            return menuDictionary.Values.Where(m => m.ParentMenuId == null).OrderBy(m => m.Order).ToList();
        }

        public async Task<List<Menu>> ListMenusAsync(Guid roleId)
        {
            var menus = await _dbContext.Set<MenuByAreaAndRole>()
                                .Where(m => m.RoleId == roleId)
                                .Select(m => m.Menu) 
                                .ToListAsync();

            var menuDictionary = menus.ToDictionary(m => m.Id);

            foreach (var menu in menus)
            {
                if (menu.ParentMenuId.HasValue && menuDictionary.ContainsKey(menu.ParentMenuId.Value))
                {
                    menuDictionary[menu.ParentMenuId.Value].ChildMenus.Add(menu);
                }
            }

            return menuDictionary.Values.Where(m => m.ParentMenuId == null).OrderBy(m => m.Order).ToList();
        }
    }
}
