using AutoMapper;
using Confluent.Kafka;
using MGP.Backoffice.CrossCutting.Exceptions;
using MGP.Backoffice.Domain.DTOs;
using MGP.Backoffice.Domain.Interface;
using MGP.Backoffice.Domain.Interfaces;
using MGP.Backoffice.Domain;
using MGP.Backoffice.Persistance.Data.Tables;
using MGP.Backoffice.Persistance.Interfaces;
using MGP.Backoffice.Persistence.Data.Tables;
using Microsoft.AspNetCore.Identity;
using Moq;
using Xunit;
using MGP.Backoffice.CrossCutting.Enum;

namespace MGP.Backoffice.Test.Service;

#pragma warning disable
public class UserServiceTests
{
    private readonly Mock<UserManager<User>> _mockUserManager;
    private readonly Mock<RoleManager<Role>> _mockRoleManager;
    private readonly Mock<IUserRepository> _mockUserRepository;
    private readonly Mock<IAreaRepository> _mockAreaRepository;
    private readonly Mock<ITicketTypeRepository> _mockAgentTicketTypeRepository;
    private readonly Mock<IAgentLeaveRepository> _mockAgentLeaveRepository;
    private readonly Mock<IMapper> _mockMapper;
    private readonly Mock<IEmailService> _mockEmailService;
    private readonly Mock<IAuditService> _mockAuditService;
    private readonly Mock<IProducer<Null, string>> _mockProducer;
    private readonly UserService _userService;

    public UserServiceTests()
    {
        _mockUserManager = new Mock<UserManager<User>>(Mock.Of<IUserStore<User>>(), null, null, null, null, null, null, null, null);
        _mockRoleManager = new Mock<RoleManager<Role>>(Mock.Of<IRoleStore<Role>>(), null, null, null, null);
        _mockUserRepository = new Mock<IUserRepository>();
        _mockAreaRepository = new Mock<IAreaRepository>();
        _mockAgentTicketTypeRepository = new Mock<ITicketTypeRepository>();
        _mockAgentLeaveRepository = new Mock<IAgentLeaveRepository>();
        _mockMapper = new Mock<IMapper>();
        _mockEmailService = new Mock<IEmailService>();
        _mockAuditService = new Mock<IAuditService>();
        _mockProducer = new Mock<IProducer<Null, string>>();

        _userService = new UserService(
            _mockUserManager.Object,
            _mockRoleManager.Object,
            _mockUserRepository.Object,
            _mockAreaRepository.Object,
            _mockAgentLeaveRepository.Object,
            _mockAgentTicketTypeRepository.Object,
            _mockMapper.Object,
            _mockEmailService.Object,
            _mockProducer.Object,
            _mockAuditService.Object
        );
    }

    [Fact]
    public async Task RegisterAsync_ShouldReturnTrue_WhenRegistrationIsSuccessful()
    {
        var registerRequestData = new RegisterRequestData
        {
            AreaId = 1,
            Role = "AGENTE",
            FirstName = "John",
            LastName = "Doe",
            EmployeeNumber = "12345",
            ManagedTicketTypes = new List<TicketTypeData> { new TicketTypeData { Id = 1 } }
        };

        var mockArea = new Area { Id = registerRequestData.AreaId };
        var mockRole = new Role { Name = registerRequestData.Role };
        var mockUser = new User { UserName = "johndoe", Email = "johndoe@example.com" };
        var mockIdentityResult = IdentityResult.Success;
        _mockAreaRepository.Setup(x => x.FindByIdAsync(registerRequestData.AreaId)).ReturnsAsync(mockArea);
        _mockRoleManager.Setup(x => x.FindByNameAsync(registerRequestData.Role)).ReturnsAsync(mockRole);
        _mockUserManager.Setup(x => x.CreateAsync(It.IsAny<User>())).ReturnsAsync(mockIdentityResult);
        _mockUserManager.Setup(x => x.AddToRoleAsync(It.IsAny<User>(), registerRequestData.Role)).ReturnsAsync(mockIdentityResult);
        _mockAgentTicketTypeRepository.Setup(x => x.ValidateAreaAndTicketTypeAsync(It.IsAny<List<int>>(), registerRequestData.AreaId)).ReturnsAsync(true);

        _mockMapper.Setup(x => x.Map<User>(It.IsAny<RegisterRequestData>())).Returns(mockUser);

        var emailTemplate = "Hello {firstName} {lastName}, your request has been received.";
        _mockEmailService.Setup(x => x.GetEmailTemplateAsync(EmailTemplateEnum.ACCESS_REQUEST)).ReturnsAsync(emailTemplate);

        var mockAdminUsers = new List<User>
        {
            new User { Email = "admin1@example.com" },
            new User { Email = "admin2@example.com" }
        };
        _mockUserManager.Setup(x => x.GetUsersInRoleAsync("ADMIN")).ReturnsAsync(mockAdminUsers);

        var result = await _userService.RegisterAsync(registerRequestData);

        Assert.True(result);

        _mockUserManager.Verify(x => x.CreateAsync(It.IsAny<User>()), Times.Once);
        _mockUserManager.Verify(x => x.AddToRoleAsync(It.IsAny<User>(), registerRequestData.Role), Times.Once);
        _mockEmailService.Verify(x => x.SendEmailAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), Times.Exactly(mockAdminUsers.Count));
    }

    [Fact]
    public async Task RegisterAsync_ShouldThrowAreaNotFoundException_WhenAreaIsNotFound()
    {
        var registerRequestData = new RegisterRequestData
        {
            AreaId = 1,
            Role = "AGENTE"
        };

        _mockAreaRepository.Setup(x => x.FindByIdAsync(registerRequestData.AreaId)).ReturnsAsync((Area)null);

        await Assert.ThrowsAsync<AreaNotFoundException>(() => _userService.RegisterAsync(registerRequestData));
    }

    [Fact]
    public async Task RegisterAsync_ShouldThrowRoleNotFoundException_WhenRoleIsNotFound()
    {
        var registerRequestData = new RegisterRequestData
        {
            AreaId = 1,
            Role = "AGENTE"
        };

        var mockArea = new Area { Id = registerRequestData.AreaId };
        _mockAreaRepository.Setup(x => x.FindByIdAsync(registerRequestData.AreaId)).ReturnsAsync(mockArea);
        _mockRoleManager.Setup(x => x.FindByNameAsync(registerRequestData.Role)).ReturnsAsync((Role)null);

        await Assert.ThrowsAsync<RoleNotFoundException>(() => _userService.RegisterAsync(registerRequestData));
    }
}