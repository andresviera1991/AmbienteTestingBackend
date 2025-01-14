using MGP.Backoffice.Domain;
using MGP.Backoffice.Persistance.Data.Tables;
using MGP.Backoffice.Persistence.Data.Tables;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MGP.Backoffice.Test.Repository
{
    public class CatalogRepositoryTest
    {
        private readonly CatalogRepository _repository;
        private readonly MyDbContext _dbContext;

        public CatalogRepositoryTest()
        {
            var options = new DbContextOptionsBuilder<MyDbContext>()
                .UseInMemoryDatabase("TestDatabaseCatalog")
                .Options;

            _dbContext = new MyDbContext(options);
            _repository = new CatalogRepository(_dbContext);
            _dbContext.Database.EnsureDeleted();
            SeedTestData();
        }

        [Fact]
        public async Task GetAreas_ShouldReturnListOfAreas()
        {
            var result = await _repository.GetAreas();

            Assert.NotEmpty(result);
            Assert.True(result.All(a => a != null));
        }

        [Fact]
        public async Task GetRoles_ShouldReturnListOfRoles()
        {
            var result = await _repository.GetRoles();

            Assert.NotEmpty(result);
            Assert.True(result.All(r => r != null));
        }

        [Fact]
        public async Task GetTicketByAreaAsync_ShouldReturnListOfTicketTypes_WhenAreaExists()
        {
            var areaName = "Test Area";
            var result = await _repository.GetTicketByAreaAsync(areaName);

            Assert.NotEmpty(result);
            Assert.True(result.All(t => t.Area.Name == areaName));
        }

        [Fact]
        public async Task ListUserStatusAsync_ShouldReturnListOfUserStatuses()
        {
            var result = await _repository.ListUserStatusAsync();

            Assert.NotEmpty(result);
            Assert.True(result.All(us => us != null));
        }

        private void SeedTestData()
        {
            var area = _dbContext.Set<Area>().FirstOrDefault(a => a.Id == 1);
            if (area == null)
            {
                area = new Area { Id = 1, Name = "Test Area" };
                _dbContext.Set<Area>().Add(area);
            }

            var role = _dbContext.Set<Role>().FirstOrDefault(r => r.Id == Guid.Parse("00000000-0000-0000-0000-000000000002"));
            if (role == null)
            {
                role = new Role { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "Test Role" };
                _dbContext.Set<Role>().Add(role);
            }

            var userStatus = _dbContext.Set<UserStatus>().FirstOrDefault(us => us.Id == 1);
            if (userStatus == null)
            {
                userStatus = new UserStatus { Id = 1, Name = "Active" };
                _dbContext.Set<UserStatus>().Add(userStatus);
            }

            var ticketType = _dbContext.Set<TicketType>().FirstOrDefault(tt => tt.Id == 1);
            if (ticketType == null)
            {
                ticketType = new TicketType
                {
                    Id = 1,
                    Name = "Test Ticket Type",
                    Area = area
                };
                _dbContext.Set<TicketType>().Add(ticketType);
            }

            _dbContext.SaveChanges();
        }
    }
}