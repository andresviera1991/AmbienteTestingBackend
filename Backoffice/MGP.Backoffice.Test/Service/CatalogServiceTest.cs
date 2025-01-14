using AutoMapper;
using MGP.Backoffice.Domain.DTOs;
using MGP.Backoffice.Domain.Interface;
using MGP.Backoffice.Domain;
using MGP.Backoffice.Persistance.DTOs;
using Moq;
using Xunit;
using MGP.Backoffice.Persistance.Data.Tables;
using MGP.Backoffice.Persistence.Data.Tables;

namespace MGP.Backoffice.Test.Service
{
    public class CatalogServiceTest
    {
        private readonly Mock<ICatalogRepository> _mockCatalogRepository;
        private readonly Mock<IMapper> _mockMapper;
        private readonly CatalogService _catalogService;

        public CatalogServiceTest()
        {
            _mockCatalogRepository = new Mock<ICatalogRepository>();
            _mockMapper = new Mock<IMapper>();
            _catalogService = new CatalogService(_mockMapper.Object, _mockCatalogRepository.Object);
        }

        [Fact]
        public async Task GetAreasAsync_ShouldReturnMappedAreas()
        {
            // Arrange
            var mockAreas = new List<AreaData>
            {
                new AreaData { Id = 1, Name = "Area 1" },
                new AreaData { Id = 2, Name = "Area 2" }
            };

            _mockCatalogRepository.Setup(repo => repo.GetAreas()).ReturnsAsync(new List<Area>
            {
                new Area { Id = 1, Name = "Area 1" },
                new Area { Id = 2, Name = "Area 2" }
            });
            _mockMapper.Setup(m => m.Map<List<AreaData>>(It.IsAny<List<Area>>())).Returns(mockAreas);

            // Act
            var result = await _catalogService.GetAreasAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(mockAreas.Count, result.Count);
            _mockCatalogRepository.Verify(repo => repo.GetAreas(), Times.Once);
            _mockMapper.Verify(m => m.Map<List<AreaData>>(It.IsAny<List<Area>>()), Times.Once);
        }

        [Fact]
        public async Task GetRolesAsync_ShouldReturnMappedRoles()
        {
            // Arrange
            var mockRoles = new List<RoleData>
            {
                new RoleData { Id = Guid.NewGuid(), Name = "Admin" },
                new RoleData { Id = Guid.NewGuid(), Name = "User" }
            };

            _mockCatalogRepository.Setup(repo => repo.GetRoles()).ReturnsAsync(new List<Role>
            {
                new Role { Id = Guid.NewGuid(), Name = "Admin" },
                new Role { Id = Guid.NewGuid(), Name = "User" }
            });
            _mockMapper.Setup(m => m.Map<List<RoleData>>(It.IsAny<List<Role>>())).Returns(mockRoles);

            // Act
            var result = await _catalogService.GetRolesAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(mockRoles.Count, result.Count);
            _mockCatalogRepository.Verify(repo => repo.GetRoles(), Times.Once);
            _mockMapper.Verify(m => m.Map<List<RoleData>>(It.IsAny<List<Role>>()), Times.Once);
        }

        [Fact]
        public async Task GetTicketByAreaAsync_ShouldReturnMappedTicketTypes()
        {
            // Arrange
            var area = "Support";
            var mockTicketTypes = new List<TicketTypeData>
            {
                new TicketTypeData { Id = 1, Name = "Support Ticket" },
                new TicketTypeData { Id = 2, Name = "General Inquiry" }
            };

            _mockCatalogRepository.Setup(repo => repo.GetTicketByAreaAsync(area)).ReturnsAsync(new List<TicketType>
            {
                new TicketType { Id = 1, Name = "Support Ticket" },
                new TicketType { Id = 2, Name = "General Inquiry" }
            });
            _mockMapper.Setup(m => m.Map<List<TicketTypeData>>(It.IsAny<List<TicketType>>())).Returns(mockTicketTypes);

            // Act
            var result = await _catalogService.GetTicketByAreaAsync(area);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(mockTicketTypes.Count, result.Count);
            _mockCatalogRepository.Verify(repo => repo.GetTicketByAreaAsync(area), Times.Once);
            _mockMapper.Verify(m => m.Map<List<TicketTypeData>>(It.IsAny<List<TicketType>>()), Times.Once);
        }

        [Fact]
        public async Task ListUserStatusAsync_ShouldReturnMappedUserStatus()
        {
            // Arrange
            var mockUserStatuses = new List<UserStatusData>
            {
                new UserStatusData { Id = 1, Name = "Active" },
                new UserStatusData { Id = 2, Name = "Inactive" }
            };

            _mockCatalogRepository.Setup(repo => repo.ListUserStatusAsync()).ReturnsAsync(new List<UserStatus>
            {
                new UserStatus { Id = 1, Name = "Active" },
                new UserStatus { Id = 2, Name = "Inactive" }
            });
            _mockMapper.Setup(m => m.Map<List<UserStatusData>>(It.IsAny<List<UserStatus>>())).Returns(mockUserStatuses);

            // Act
            var result = await _catalogService.ListUserStatusAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(mockUserStatuses.Count, result.Count);
            _mockCatalogRepository.Verify(repo => repo.ListUserStatusAsync(), Times.Once);
            _mockMapper.Verify(m => m.Map<List<UserStatusData>>(It.IsAny<List<UserStatus>>()), Times.Once);
        }
    }
}