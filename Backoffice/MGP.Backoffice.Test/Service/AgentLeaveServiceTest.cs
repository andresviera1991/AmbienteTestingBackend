using AutoMapper;
using MGP.Backoffice.CrossCutting.Exceptions;
using MGP.Backoffice.Domain.DTOs;
using MGP.Backoffice.Domain.Interface;
using MGP.Backoffice.Domain;
using MGP.Backoffice.Persistance.Data.Tables;
using MGP.Backoffice.Persistance.Interfaces;
using Moq;
using Xunit;
using MGP.Backoffice.Persistance.DTOs;

namespace MGP.Backoffice.Test.Service
{
    public class AgentLeaveServiceTest
    {
        private readonly Mock<IUserService> _mockUserService;
        private readonly Mock<IAgentLeaveRepository> _mockAgentLeaveRepository;
        private readonly Mock<IMapper> _mockMapper;
        private readonly AgentLeaveService _agentLeaveService;

        public AgentLeaveServiceTest()
        {
            _mockUserService = new Mock<IUserService>();
            _mockAgentLeaveRepository = new Mock<IAgentLeaveRepository>();
            _mockMapper = new Mock<IMapper>();

            _agentLeaveService = new AgentLeaveService(
                _mockUserService.Object,
                _mockAgentLeaveRepository.Object,
                _mockMapper.Object
            );
        }

        [Fact]
        public async Task CreateAgentLeaveAsync_ShouldReturnAgentLeaveData_WhenSuccessful()
        {
            var agentLeaveData = new AgentLeaveData
            {
                AgentId = Guid.NewGuid(),
                StartDate = DateTime.UtcNow.AddDays(1),
                EndDate = DateTime.UtcNow.AddDays(5)
            };

            var mockUser = new UserData { Id = agentLeaveData.AgentId, UserName = "johndoe" };

            _mockUserService.Setup(x => x.GetUserByIdAsync(agentLeaveData.AgentId)).ReturnsAsync(mockUser); // Asegurarse de que GetUserByIdAsync no devuelva null
            _mockAgentLeaveRepository.Setup(x => x.AgentHasVacationAsync(It.IsAny<Guid>(), It.IsAny<DateTime>(), It.IsAny<DateTime>())).ReturnsAsync(false); // No hay vacaciones previas

            var mockAgentLeave = new AgentLeave
            {
                AgentId = agentLeaveData.AgentId,
                StartDate = agentLeaveData.StartDate,
                EndDate = agentLeaveData.EndDate,
                CreationDate = DateTime.UtcNow
            };

            _mockAgentLeaveRepository.Setup(x => x.CreateAsync(It.IsAny<AgentLeave>())).ReturnsAsync(mockAgentLeave);

            var mockAgentLeaveData = new AgentLeaveData
            {
                AgentId = agentLeaveData.AgentId,
                StartDate = agentLeaveData.StartDate,
                EndDate = agentLeaveData.EndDate
            };

            _mockMapper.Setup(x => x.Map<AgentLeaveData>(It.IsAny<AgentLeave>())).Returns(mockAgentLeaveData);
            _mockMapper.Setup(x => x.Map<AgentLeave>(It.IsAny<AgentLeaveData>())).Returns(mockAgentLeave);
            
            var result = await _agentLeaveService.CreateAgentLeaveAsync(agentLeaveData);

            Assert.NotNull(result);
            Assert.Equal(agentLeaveData.AgentId, result.AgentId);
            Assert.Equal(agentLeaveData.StartDate, result.StartDate);
            Assert.Equal(agentLeaveData.EndDate, result.EndDate);

            _mockUserService.Verify(x => x.GetUserByIdAsync(agentLeaveData.AgentId), Times.Once);
            _mockAgentLeaveRepository.Verify(x => x.AgentHasVacationAsync(It.IsAny<Guid>(), It.IsAny<DateTime>(), It.IsAny<DateTime>()), Times.Once);
            _mockAgentLeaveRepository.Verify(x => x.CreateAsync(It.IsAny<AgentLeave>()), Times.Once);
            _mockMapper.Verify(x => x.Map<AgentLeaveData>(It.IsAny<AgentLeave>()), Times.Once);
        }

        [Fact]
        public async Task CreateAgentLeaveAsync_ShouldThrowAgentHasVacationException_WhenVacationAlreadyExists()
        {
            var agentLeaveData = new AgentLeaveData
            {
                AgentId = Guid.NewGuid(),
                StartDate = DateTime.UtcNow.AddDays(1),
                EndDate = DateTime.UtcNow.AddDays(5)
            };

            var mockUser = new UserData { Id = agentLeaveData.AgentId, UserName = "johndoe" };

            _mockUserService.Setup(x => x.GetUserByIdAsync(agentLeaveData.AgentId)).ReturnsAsync(mockUser);
            _mockAgentLeaveRepository.Setup(x => x.AgentHasVacationAsync(It.IsAny<Guid>(), It.IsAny<DateTime>(), It.IsAny<DateTime>())).ReturnsAsync(true); // Ya existe una vacación

            await Assert.ThrowsAsync<AgentHasVacationException>(() => _agentLeaveService.CreateAgentLeaveAsync(agentLeaveData));

            _mockUserService.Verify(x => x.GetUserByIdAsync(agentLeaveData.AgentId), Times.Once);
            _mockAgentLeaveRepository.Verify(x => x.AgentHasVacationAsync(It.IsAny<Guid>(), It.IsAny<DateTime>(), It.IsAny<DateTime>()), Times.Once);
            _mockAgentLeaveRepository.Verify(x => x.CreateAsync(It.IsAny<AgentLeave>()), Times.Never);
        }
    }
}