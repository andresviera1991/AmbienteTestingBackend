using MGP.Backoffice.Persistance.Data.Tables;
using MGP.Backoffice.Persistance;
using MGP.Backoffice.Persistence.Data.Tables;
using Microsoft.EntityFrameworkCore;
using Xunit;
using MGP.Backoffice.Persistance.Interfaces;

namespace MGP.Backoffice.Test.Repository
{
    public class AgentLeaveRepositoryTest
    {
        private readonly IAgentLeaveRepository _repository;
        private readonly MyDbContext _dbContext;

        public AgentLeaveRepositoryTest()
        {
            var options = new DbContextOptionsBuilder<MyDbContext>()
                .UseInMemoryDatabase("TestDatabaseAgentLeave")
                .Options;

            _dbContext = new MyDbContext(options);
            _repository = new AgentLeaveRepository(_dbContext);
            _dbContext.Database.EnsureDeleted();
            SeedTestData();
        }

        [Fact]
        public async Task GetAgentLeaveByIdAsync_ShouldReturnAgentLeave_WhenExists()
        {

            var result = await _repository.GetAgentLeaveByIdAsync(Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a77"));

            Assert.NotNull(result);
            Assert.Equal(Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a77"), result.Id);
        }

        [Fact]
        public async Task FindByStartDateOrEndDateAsync_ShouldReturnLeaves_WhenMatchFound()
        {
            var result = await _repository.FindByStartDateOrEndDateAsync();

            Assert.NotEmpty(result);
        }

        [Fact]
        public async Task AgentLeaveByAgentIdAsync_ShouldReturnAgentLeaves_WhenAgentHasLeaves()
        {
            Guid agentId = Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a78");
            var result = await _repository.AgentLeaveByAgentIdAsync(agentId);

            Assert.NotEmpty(result);
            Assert.Equal(agentId, result.First().AgentId);
            Assert.Equal(Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a77"), result.First().Id);
        }

        [Fact]
        public async Task AgentHasVacationAsync_ShouldReturnTrue_WhenVacationIsFound()
        {
            var agentId = Guid.NewGuid();
            var startDate = DateTime.UtcNow;
            var endDate = DateTime.UtcNow.AddDays(1);

            var agentLeave = new AgentLeave
            {
                Id = Guid.NewGuid(),
                StartDate = startDate,
                EndDate = endDate,
                AgentId = agentId,
                CreationDate = DateTime.UtcNow
            };

            await _repository.CreateAsync(agentLeave);

            var result = await _repository.AgentHasVacationAsync(agentId, startDate, endDate);

            Assert.True(result);
        }

        [Fact]
        public async Task CreateAsync_ShouldCreateAgentLeave_WhenValidData()
        {
            var agentLeave = new AgentLeave
            {
                Id = Guid.NewGuid(),
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(1),
                AgentId = Guid.NewGuid(),
                CreationDate = DateTime.UtcNow
            };

            var result = await _repository.CreateAsync(agentLeave);

            Assert.NotNull(result);
            Assert.Equal(agentLeave.Id, result.Id);
        }

        [Fact]
        public async Task UpdateAsync_ShouldUpdateAgentLeave_WhenValidData()
        {
            var agentLeave = new AgentLeave
            {
                Id = Guid.NewGuid(),
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(1),
                AgentId = Guid.NewGuid(),
                CreationDate = DateTime.UtcNow
            };

            var createdAgentLeave = await _repository.CreateAsync(agentLeave);

            createdAgentLeave.EndDate = DateTime.UtcNow.AddDays(2);

            var updatedAgentLeave = await _repository.UpdateAsync(createdAgentLeave);

            Assert.Equal(createdAgentLeave.EndDate, updatedAgentLeave.EndDate);
        }

        private void SeedTestData()
        {
            var area = _dbContext.Set<Area>().FirstOrDefault(a => a.Id == 1);
            if (area == null)
            {
                area = new Area { Id = 1 };
                _dbContext.Set<Area>().Add(area);
            }

            var user = _dbContext.Set<User>().FirstOrDefault(u => u.Id == Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a78"));
            if (user == null)
            {
                user = new User
                {
                    Id = Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a78"),
                    Area = area
                };
                _dbContext.Set<User>().Add(user);
            }

            var agentLeave = _dbContext.Set<AgentLeave>().FirstOrDefault(a => a.Id == Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a77"));
            if (agentLeave == null)
            {
                agentLeave = new AgentLeave
                {
                    Id = Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a77"),
                    StartDate = DateTime.UtcNow,
                    EndDate = DateTime.UtcNow.AddDays(1),
                    AgentId = Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a78"),
                    CreationDate = DateTime.UtcNow,
                    Agent = user
                };
                _dbContext.Set<AgentLeave>().Add(agentLeave);
            }

            _dbContext.SaveChanges();
        }
    }
}