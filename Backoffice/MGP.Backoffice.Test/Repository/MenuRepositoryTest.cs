using MGP.Backoffice.Persistance.Data.Tables;
using MGP.Backoffice.Persistance;
using MGP.Backoffice.Persistence.Data.Tables;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MGP.Backoffice.Test.Repository
{
    public class MenuRepositoryTest
    {
        private readonly MenuRepository _repository;
        private readonly MyDbContext _dbContext;

        public MenuRepositoryTest()
        {
            var options = new DbContextOptionsBuilder<MyDbContext>()
                .UseInMemoryDatabase("TestDatabaseMenu")
                .Options;

            _dbContext = new MyDbContext(options);
            _repository = new MenuRepository(_dbContext);
            _dbContext.Database.EnsureDeleted();
            SeedTestData();
        }

        [Fact]
        public async Task ListMenusAsync_ShouldReturnListOfMenus_WhenRoleAndAreaExist()
        {
            var roleId = Guid.Parse("00000000-0000-0000-0000-000000000002");
            var areaId = 1;

            var result = await _repository.ListMenusAsync(roleId, areaId);

            Assert.NotEmpty(result);
            Assert.True(result.All(m => m != null));
        }

        [Fact]
        public async Task ListMenusAsync_ShouldReturnListOfMenus_WhenRoleExists()
        {
            var roleId = Guid.Parse("00000000-0000-0000-0000-000000000002");

            var result = await _repository.ListMenusAsync(roleId);

            Assert.NotEmpty(result);
            Assert.True(result.All(m => m != null));
        }

        private void SeedTestData()
        {
            var roleId = Guid.Parse("00000000-0000-0000-0000-000000000002");
            var areaId = 1;

            var menu1 = new Menu
            {
                Id = 1,
                Name = "Menu1",
                ParentMenuId = null,
                Order = 1,
                Label = "Menu1 Label"
            };
            var menu2 = new Menu
            {
                Id = 2,
                Name = "Menu2",
                ParentMenuId = 1,
                Order = 2,
                Label = "Menu2 Label"
            };
            var menu3 = new Menu
            {
                Id = 3,
                Name = "Menu3",
                ParentMenuId = 1,
                Order = 3,
                Label = "Menu3 Label"
            };

            _dbContext.Set<Menu>().AddRange(menu1, menu2, menu3);
            _dbContext.SaveChanges();

            _dbContext.Set<MenuByAreaAndRole>().AddRange(
                new MenuByAreaAndRole { RoleId = roleId, AreaId = areaId, MenuId = 1 },
                new MenuByAreaAndRole { RoleId = roleId, AreaId = areaId, MenuId = 2 },
                new MenuByAreaAndRole { RoleId = roleId, AreaId = areaId, MenuId = 3 }
            );
            _dbContext.SaveChanges();
        }
    }
}