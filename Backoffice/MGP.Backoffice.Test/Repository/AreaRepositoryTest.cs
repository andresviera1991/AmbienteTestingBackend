using MGP.Backoffice.CrossCutting.Exceptions;
using MGP.Backoffice.Persistance.Data.Tables;
using MGP.Backoffice.Persistance.Interfaces;
using MGP.Backoffice.Persistance;
using MGP.Backoffice.Persistence.Data.Tables;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MGP.Backoffice.Test.Repository
{
    public class AreaRepositoryTest
    {
        private readonly IAreaRepository _repository;
        private readonly MyDbContext _dbContext;

        public AreaRepositoryTest()
        {
            var options = new DbContextOptionsBuilder<MyDbContext>()
                .UseInMemoryDatabase("TestDatabase")
                .Options;

            _dbContext = new MyDbContext(options);
            _repository = new AreaRepository(_dbContext);
            _dbContext.Database.EnsureDeleted();
            SeedTestData();
        }

        [Fact]
        public async Task AreaExistsAsync_ShouldReturnTrue_WhenAreaExists()
        {
            var areaId = 1;

            var result = await _repository.AreaExistsAsync(areaId);

            Assert.True(result);
        }

        [Fact]
        public async Task AreaExistsAsync_ShouldReturnFalse_WhenAreaDoesNotExist()
        {
            var areaId = 999;

            var result = await _repository.AreaExistsAsync(areaId);

            Assert.False(result);
        }

        [Fact]
        public async Task FindByIdAsync_ShouldReturnArea_WhenAreaExists()
        {
            var areaId = 1;

            var result = await _repository.FindByIdAsync(areaId);

            Assert.NotNull(result);
            Assert.Equal(areaId, result.Id);
        }

        [Fact]
        public async Task FindByIdAsync_ShouldThrowAreaNotFoundException_WhenAreaDoesNotExist()
        {
            var areaId = 999;

            await Assert.ThrowsAsync<AreaNotFoundException>(() => _repository.FindByIdAsync(areaId));
        }

        [Fact]
        public async Task FindByNameAsync_ShouldReturnArea_WhenAreaExists()
        {
            var areaName = "Test Area";

            var result = await _repository.FindByNameAsync(areaName);

            Assert.NotNull(result);
            Assert.Equal(areaName, result.Name);
        }

        [Fact]
        public async Task FindByNameAsync_ShouldThrowAreaNotFoundException_WhenAreaDoesNotExist()
        {
            var areaName = "NonExistentArea";

            await Assert.ThrowsAsync<AreaNotFoundException>(() => _repository.FindByNameAsync(areaName));
        }

        private void SeedTestData()
        {
            var area = new Area
            {
                Id = 1,
                Name = "Test Area"
            };

            _dbContext.Set<Area>().Add(area);
            _dbContext.SaveChanges();
        }
    }
}