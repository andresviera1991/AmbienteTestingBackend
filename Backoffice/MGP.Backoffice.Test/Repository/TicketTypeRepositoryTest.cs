using MGP.Backoffice.CrossCutting.Exceptions;
using MGP.Backoffice.Persistance.Data.Tables;
using MGP.Backoffice.Persistance;
using MGP.Backoffice.Persistence.Data.Tables;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MGP.Backoffice.Test.Repository;

#pragma warning disable
public class TicketTypeRepositoryTest
{
    private readonly TicketTypeRepository _repository;
    private readonly MyDbContext _dbContext;

    public TicketTypeRepositoryTest()
    {
        var options = new DbContextOptionsBuilder<MyDbContext>()
            .UseInMemoryDatabase("TestDatabaseTicketType")
            .Options;

        _dbContext = new MyDbContext(options);
        _repository = new TicketTypeRepository(_dbContext);
        _dbContext.Database.EnsureDeleted();
        SeedTestData();
    }

    [Fact]
    public async Task AddTicketTypeAsync_ShouldAddTicketTypes_WhenValidData()
    {
        var agentId = Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a78");
        var ticketTypeIds = new List<int> { 1, 2 };
        var areaId = 1;

        await _repository.AddTicketTypeAsync(agentId, ticketTypeIds, areaId);
        var result = await _dbContext.Set<AgentTicketType>()
                                     .Where(at => at.AgentId == agentId)
                                     .ToListAsync();

        Assert.Equal(1, result.Count);
        Assert.True(result.All(at => at.AgentId == agentId && ticketTypeIds.Contains(at.TicketTypeId)));
    }

    [Fact]
    public async Task ValidateAreaAndTicketTypeAsync_ShouldReturnTrue_WhenValidTicketTypes()
    {
        var ticketTypeIds = new List<int> { 1, 2 };
        var areaId = 1;

        var result = await _repository.ValidateAreaAndTicketTypeAsync(ticketTypeIds, areaId);

        Assert.True(result);
    }

    [Fact]
    public async Task ValidateAreaAndTicketTypeAsync_ShouldThrowException_WhenInvalidTicketTypes()
    {
        var ticketTypeIds = new List<int> { 999 };
        var areaId = 1;

        await Assert.ThrowsAsync<AreaTicketTypeException>(() => _repository.ValidateAreaAndTicketTypeAsync(ticketTypeIds, areaId));
    }

    [Fact]
    public async Task GetTicketTypesByUserIdAsync_ShouldReturnList_WhenAgentHasTicketTypes()
    {
        var result = await _repository.GetTicketTypesByUserIdAsync(Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a78"));

        Assert.NotEmpty(result);
        Assert.Equal(1, result.Count);
    }

    [Fact]
    public async Task GetTicketTypesByUserIdAsync_ShouldReturnEmptyList_WhenAgentHasNoTicketTypes()
    {
        var agentId = Guid.NewGuid();

        var result = await _repository.GetTicketTypesByUserIdAsync(agentId);

        Assert.Empty(result);
    }

    //[Fact]
    //public async Task RemoveTicketTypesAsync_ShouldRemoveTicketTypes_WhenAgentHasTicketTypes()
    //{
    //    var agentId = Guid.NewGuid();
    //    var ticketTypes = new List<TicketType>
    //    {
    //        new TicketType { Id = 1, Name = "TicketType1", AreaId = 1 }
    //    };

    //    _dbContext.Set<TicketType>().AddRange(ticketTypes);
    //    _dbContext.SaveChanges();

    //    var agentTicketTypes = new List<AgentTicketType>
    //    {
    //        new AgentTicketType { AgentId = agentId, TicketTypeId = 1, CreationDate = DateTime.UtcNow }
    //    };
    //    _dbContext.Set<AgentTicketType>().AddRange(agentTicketTypes);
    //    _dbContext.SaveChanges();

    //    await _repository.RemoveTicketTypesAsync(agentId);
    //    var result = await _dbContext.Set<AgentTicketType>()
    //                                 .Where(at => at.AgentId == agentId)
    //                                 .ToListAsync();

    //    Assert.Empty(result);
    //}

    [Fact]
    public async Task FindByNameAsync_ShouldReturnTicketType_WhenFound()
    {
        var result = await _repository.FindByNameAsync("Test Ticket Type 1");

        Assert.NotNull(result);
        Assert.Equal("Test Ticket Type 1", result.Name);
    }

    [Fact]
    public async Task FindByNameAsync_ShouldThrowException_WhenNotFound()
    {
        var ticketTypeName = "Non Existent Ticket Type";

        await Assert.ThrowsAsync<AreaNotFoundException>(() => _repository.FindByNameAsync(ticketTypeName));
    }

    private void SeedTestData()
    {
        var area = _dbContext.Set<Area>().FirstOrDefault(a => a.Id == 1);
        if (area == null)
        {
            area = new Area { Id = 1, Name = "Test Area" };
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

        var ticketType1 = _dbContext.Set<TicketType>().FirstOrDefault(t => t.Id == 1);
        if (ticketType1 == null)
        {
            ticketType1 = new TicketType { Id = 1, Name = "Test Ticket Type 1", AreaId = 1 };
            _dbContext.Set<TicketType>().Add(ticketType1);
        }

        var ticketType2 = _dbContext.Set<TicketType>().FirstOrDefault(t => t.Id == 2);
        if (ticketType2 == null)
        {
            ticketType2 = new TicketType { Id = 2, Name = "Test Ticket Type 2", AreaId = 1 };
            _dbContext.Set<TicketType>().Add(ticketType2);
        }

        var agentTicketType = _dbContext.Set<AgentTicketType>().FirstOrDefault(t => t.AgentId == Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a78"));
        if (agentTicketType == null)
        {
            agentTicketType = new AgentTicketType { Id = Guid.NewGuid(), AgentId = Guid.Parse("f5bbe838-3f8a-4ccc-9047-107db02c4a78"), TicketTypeId = 1 };
            _dbContext.Set<AgentTicketType>().Add(agentTicketType);
        }
        _dbContext.SaveChanges();
    }
}