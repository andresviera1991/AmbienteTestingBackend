using MGP.Backoffice.CrossCutting.Exceptions;
using MGP.Backoffice.Persistance.Data.Tables;
using MGP.Backoffice.Persistance.DTOs;
using MGP.Backoffice.Persistance;
using MGP.Backoffice.Persistence.Data.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.Identity;

namespace MGP.Backoffice.Test.Repository
{
    public class UserRepositoryTest
    {
        private readonly UserRepository _repository;
        private readonly MyDbContext _dbContext;

        public UserRepositoryTest()
        {
            var options = new DbContextOptionsBuilder<MyDbContext>()
                .UseInMemoryDatabase("TestDatabaseUser")
                .Options;

            _dbContext = new MyDbContext(options);
            _repository = new UserRepository(_dbContext);
            _dbContext.Database.EnsureDeleted();
            SeedTestData();
        }

        [Fact]
        public async Task AddAgentToQueue_ShouldAddAgent_WhenValidAgent()
        {
            var agent = new User
            {
                Id = Guid.NewGuid(),
                UserName = "testAgent",
                AreaId = 1,
                UserStatusId = 1
            };

            _repository.AddAgentToQueue(agent);

            var lastAgent = await _dbContext.Set<User>()
                .OrderByDescending(u => u.QueuePosition)
                .FirstOrDefaultAsync();

            Assert.NotNull(lastAgent);
            Assert.Equal(1, lastAgent.QueuePosition);
        }

        [Fact]
        public async Task GetUserAsync_ShouldReturnUser_WhenUserExists()
        {
            var result = await _repository.GetUserAsync(Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a78"));

            Assert.NotNull(result);
            Assert.Equal(Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a78"), result.Id);
        }

        [Fact]
        public async Task GetUserAsync_ShouldThrowNotFoundException_WhenUserDoesNotExist()
        {
            await Assert.ThrowsAsync<NotFoundException>(() => _repository.GetUserAsync(Guid.NewGuid()));
        }

        [Fact]
        public async Task GetUsersByRoleAreaAndTicketTypeAsync_ShouldReturnUsers_WhenRoleAreaAndTicketTypeMatch()
        {
            var roleId = Guid.Parse("00000000-0000-0000-0000-000000000002");
            var areaId = 1;
            var ticketTypeId = 1;

            var users = await _repository.GetUsersByRoleAreaAndTicketTypeAsync(new Role { Id = roleId }, new Area { Id = areaId }, new TicketType { Id = ticketTypeId });

            Assert.NotNull(users);
            Assert.NotEmpty(users);
        }

        [Fact]
        public async Task ListAgentsByTicketTypeAsync_ShouldReturnAgents_WhenTicketTypeIsValid()
        {
            var ticketTypeId = 1;

            var agents = await _repository.ListAgentsByTicketTypeAsync(ticketTypeId);

            Assert.NotNull(agents);
            Assert.NotEmpty(agents);
        }

        [Fact]
        public async Task ListAgentsByFilters_ShouldReturnFilteredAgents_WhenFiltersAreApplied()
        {
            var filters = new ListAgentByFiltersData
            {
                PageNumber = 1,
                PageSize = 10,
                Role = "Test Role",
                Area = "Test Area"
            };

            var agents = await _repository.ListAgentsByFilters(filters);

            Assert.NotNull(agents);
            Assert.NotEmpty(agents);
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

            var user = _dbContext.Set<User>().FirstOrDefault(u => u.Id == Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a78"));
            if (user == null)
            {
                user = new User
                {
                    Id = Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a78"),
                    UserName = "testUser",
                    Area = area,
                    UserStatusId = 1,
                    UserStatus = new UserStatus()
                    {
                        Id = 1,
                        Name = "Active",
                        CreationDate = DateTime.UtcNow
                    }
                };
                _dbContext.Set<User>().Add(user);
            }

            var ticketType1 = _dbContext.Set<TicketType>().FirstOrDefault(t => t.Id == 1);
            if (ticketType1 == null)
            {
                ticketType1 = new TicketType { Id = 1, Name = "Test Ticket Type 1", AreaId = 1 };
                _dbContext.Set<TicketType>().Add(ticketType1);
            }

            var agentTicketType = _dbContext.Set<AgentTicketType>().FirstOrDefault(t => t.AgentId == Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a78"));
            if (agentTicketType == null)
            {
                agentTicketType = new AgentTicketType
                {
                    Id = Guid.NewGuid(),
                    AgentId = Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a78"),
                    TicketTypeId = 1
                };
                _dbContext.Set<AgentTicketType>().Add(agentTicketType);
            }

            var identityUserRole = _dbContext.Set<IdentityUserRole<Guid>>().FirstOrDefault(ur => ur.UserId == Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a78"));
            if (identityUserRole == null)
            {
                identityUserRole = new IdentityUserRole<Guid>
                {
                    UserId = Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a78"),
                    RoleId = Guid.Parse("00000000-0000-0000-0000-000000000002")
                };
                _dbContext.Set<IdentityUserRole<Guid>>().Add(identityUserRole);
            }

            _dbContext.SaveChanges();
        }
    }
}