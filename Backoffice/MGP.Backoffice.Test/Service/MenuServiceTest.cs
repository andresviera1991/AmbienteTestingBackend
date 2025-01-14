using AutoMapper;
using MGP.Backoffice.CrossCutting.Exceptions;
using MGP.Backoffice.Domain.DTOs;
using MGP.Backoffice.Domain;
using MGP.Backoffice.Persistance.Data.Tables;
using MGP.Backoffice.Persistance.Interfaces;
using MGP.Backoffice.Persistence.Data.Tables;
using Microsoft.AspNetCore.Identity;
using Moq;
using Xunit;

#pragma warning disable
namespace MGP.Backoffice.Test.Service;

public class MenuServiceTest
{
    private readonly Mock<IMenuRepository> _mockMenuRepository;
    private readonly Mock<IAreaRepository> _mockAreaRepository;
    private readonly Mock<RoleManager<Role>> _mockRoleManager;
    private readonly Mock<IMapper> _mockMapper;
    private readonly MenuService _menuService;

    public MenuServiceTest()
    {
        _mockMenuRepository = new Mock<IMenuRepository>();
        _mockAreaRepository = new Mock<IAreaRepository>();
        _mockRoleManager = new Mock<RoleManager<Role>>(Mock.Of<IRoleStore<Role>>(), null, null, null, null);
        _mockMapper = new Mock<IMapper>();

        _menuService = new MenuService(
            _mockMenuRepository.Object,
            _mockRoleManager.Object,
            _mockMapper.Object,
            _mockAreaRepository.Object
        );
    }

    [Fact]
    public async Task ListMenusAsync_ShouldReturnMenus_WhenRoleIsAdmin()
    {
        // Arrange
        var areaRolData = new AreaRolData { Role = "ADMIN", Area = "AnyArea" };
        var role = new Role { Name = "ADMIN", Id = Guid.NewGuid() };

        var menus = new List<Menu>
        {
            new Menu
            {
                Id = 1,
                Label = "Menu1",
                Icon = "Icon1",
                Url = "/menu1",
                Order = 1,
                IsActive = true,
                ChildMenus = new List<Menu>
                {
                    new Menu
                    {
                        Id = 2,
                        Label = "ChildMenu1",
                        Icon = "Icon2",
                        Url = "/menu1/child",
                        Order = 2,
                        IsActive = true
                    }
                }
            }
        };

        var menuDtos = new List<MenuDto>
        {
            new MenuDto
            {
                Id = 1,
                Label = "Menu1",
                Icon = "Icon1",
                Url = "/menu1",
                Order = 1,
                IsActive = true,
                ChildMenus = new List<MenuDto>
                {
                    new MenuDto
                    {
                        Id = 2,
                        Label = "ChildMenu1",
                        Icon = "Icon2",
                        Url = "/menu1/child",
                        Order = 2,
                        IsActive = true
                    }
                }
            }
        };

        _mockRoleManager.Setup(rm => rm.FindByNameAsync(It.IsAny<string>())).ReturnsAsync(role);
        _mockMenuRepository.Setup(mr => mr.ListMenusAsync(It.IsAny<Guid>())).ReturnsAsync(menus);
        _mockMapper.Setup(m => m.Map<List<MenuDto>>(It.IsAny<IEnumerable<Menu>>())).Returns(menuDtos);

        // Act
        var result = await _menuService.ListMenusAsync(areaRolData);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(1, result.Count);
        Assert.Equal("Menu1", result[0].Label);
        Assert.Equal(1, result[0].ChildMenus.Count);
        Assert.Equal("ChildMenu1", result[0].ChildMenus[0].Label);
    }

    [Fact]
    public async Task ListMenusAsync_ShouldReturnMenus_WhenRoleIsNotAdmin()
    {
        // Arrange
        var areaRolData = new AreaRolData { Role = "User", Area = "Area1" };
        var role = new Role { Name = "User", Id = Guid.NewGuid() };
        var area = new Area { Id = 1, Name = "Area1" };

        var menus = new List<Menu>
        {
            new Menu
            {
                Id = 3,
                Label = "Menu3",
                Icon = "Icon3",
                Url = "/menu3",
                Order = 3,
                IsActive = true,
                ChildMenus = new List<Menu>
                {
                    new Menu
                    {
                        Id = 4,
                        Label = "ChildMenu2",
                        Icon = "Icon4",
                        Url = "/menu3/child",
                        Order = 4,
                        IsActive = true
                    }
                }
            }
        };

        var menuDtos = new List<MenuDto>
        {
            new MenuDto
            {
                Id = 3,
                Label = "Menu3",
                Icon = "Icon3",
                Url = "/menu3",
                Order = 3,
                IsActive = true,
                ChildMenus = new List<MenuDto>
                {
                    new MenuDto
                    {
                        Id = 4,
                        Label = "ChildMenu2",
                        Icon = "Icon4",
                        Url = "/menu3/child",
                        Order = 4,
                        IsActive = true
                    }
                }
            }
        };

        _mockRoleManager.Setup(rm => rm.FindByNameAsync(It.IsAny<string>())).ReturnsAsync(role);
        _mockAreaRepository.Setup(ar => ar.FindByNameAsync(It.IsAny<string>())).ReturnsAsync(area);
        _mockMenuRepository.Setup(mr => mr.ListMenusAsync(It.IsAny<Guid>(), It.IsAny<int>())).ReturnsAsync(menus);
        _mockMapper.Setup(m => m.Map<List<MenuDto>>(It.IsAny<IEnumerable<Menu>>())).Returns(menuDtos);

        // Act
        var result = await _menuService.ListMenusAsync(areaRolData);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(1, result.Count);
        Assert.Equal("Menu3", result[0].Label);
        Assert.Equal(1, result[0].ChildMenus.Count);
        Assert.Equal("ChildMenu2", result[0].ChildMenus[0].Label);
    }

    [Fact]
    public async Task ListMenusAsync_ShouldThrowRoleNotFoundException_WhenRoleDoesNotExist()
    {
        // Arrange
        var areaRolData = new AreaRolData { Role = "NonExistingRole", Area = "Area1" };

        _mockRoleManager.Setup(rm => rm.FindByNameAsync(It.IsAny<string>())).ReturnsAsync((Role)null);

        // Act & Assert
        await Assert.ThrowsAsync<RoleNotFoundException>(() => _menuService.ListMenusAsync(areaRolData));
    }

    [Fact]
    public async Task ListMenusAsync_ShouldThrowAreaNotFoundException_WhenAreaDoesNotExist()
    {
        // Arrange
        var areaRolData = new AreaRolData { Role = "User", Area = "NonExistingArea" };
        var role = new Role { Name = "User", Id = Guid.NewGuid() };

        _mockRoleManager.Setup(rm => rm.FindByNameAsync(It.IsAny<string>())).ReturnsAsync(role);
        _mockAreaRepository.Setup(ar => ar.FindByNameAsync(It.IsAny<string>())).ReturnsAsync((Area)null);

        // Act & Assert
        await Assert.ThrowsAsync<AreaNotFoundException>(() => _menuService.ListMenusAsync(areaRolData));
    }
}