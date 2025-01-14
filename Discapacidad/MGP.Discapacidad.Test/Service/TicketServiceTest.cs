using AutoMapper;
using FluentAssertions;
using MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.CUD.Get;
using MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.PARKING.Get;
using MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.SUBE.Get;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.CUD.Get;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.PARKING.Get;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.SUBE.Get;
using MGP.Discapacidad.Client.DTOs.Response;
using MGP.Discapacidad.Client.Interface.Authentication;
using MGP.Discapacidad.Client.Interface.Backoffice;
using MGP.Discapacidad.CrossCutting.Enum;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.Domain.interfaces;
using MGP.Discapacidad.Domain.Services;
using MGP.Discapacidad.Persistance.Data.Tables;
using MGP.Discapacidad.Persistance.DTOs.Catalog;
using MGP.Discapacidad.Persistance.DTOs.Document;
using MGP.Discapacidad.Persistance.DTOs.Ticket;
using MGP.Discapacidad.Persistance.Interface;
using Moq;
using Xunit;
namespace MGP.Discapacidad.Test.Service;

#pragma warning disable
public class TicketServiceTest
{
    private readonly Mock<ITicketRepository> _ticketRepositoryMock;
    private readonly Mock<IDocumentService> _documentServiceMock;
    private readonly Mock<IMapper> _mapperMock;
    private readonly Mock<IAuditService> _auditServiceMock;
    private readonly Mock<INotificationService> _notificationServiceMock;
    private readonly Mock<IEmailService> _emailServiceMock;
    private readonly Mock<IBackofficeClient> _backofficeClientMock;
    private readonly Mock<IAuthenticationClient> _authenticationClientMock;

    private readonly TicketService _ticketService;

    public TicketServiceTest()
    {
        _ticketRepositoryMock = new Mock<ITicketRepository>();
        _documentServiceMock = new Mock<IDocumentService>();
        _mapperMock = new Mock<IMapper>();
        _auditServiceMock = new Mock<IAuditService>();
        _notificationServiceMock = new Mock<INotificationService>();
        _emailServiceMock = new Mock<IEmailService>();
        _backofficeClientMock = new Mock<IBackofficeClient>();
        _authenticationClientMock = new Mock<IAuthenticationClient>();

        _ticketService = new TicketService(_ticketRepositoryMock.Object,
                                     _documentServiceMock.Object,
                                     _mapperMock.Object,
                                     _auditServiceMock.Object,
                                     _notificationServiceMock.Object,
                                     _emailServiceMock.Object,
                                     _backofficeClientMock.Object,
                                     _authenticationClientMock.Object);
    }

    #region CREATE METHODS

    #region CUD
    [Fact]
    public async Task Service_ShouldReturnCreateTicketCudData_WhenDataIsValid()
    {
        //Arrange
        var requestData = CreateTicketCudData();
        var documentData = CreateDocumentsData();
        var agentId = Guid.NewGuid();
        var ticket = CreateTicket();

        _ticketRepositoryMock.Setup(t => t.TicketOpenExistAsync(requestData.UserId, TicketTypeEnum.CUD)).ReturnsAsync(false);
        _documentServiceMock.Setup(d => d.UploadImageAsync(requestData.Documents)).ReturnsAsync(documentData);
        _backofficeClientMock.Setup(d => d.GetNextAvailableAgentAsync("CUD")).ReturnsAsync(agentId);
        _ticketRepositoryMock.Setup(t => t.CreateTicketCudAsync(requestData)).ReturnsAsync(ticket);
        _mapperMock.Setup(m => m.Map<CreateTicketCudData>(ticket)).Returns(requestData);

        //Act
        var response = await _ticketService.CreateTicketCudAsync(requestData);

        //Assert
        response.Should().NotBeNull();
        response.TicketCode.Should().Be("TICKET123");
    }

    [Fact]
    public async Task CreateTicketCudAsync_WhenTicketAlreadyOpen_ThrowsTicketAlreadyOpenException()
    {
        //Arrange
        var requestData = CreateTicketCudData();

        _ticketRepositoryMock.Setup(t => t.TicketOpenExistAsync(requestData.UserId, TicketTypeEnum.CUD)).ReturnsAsync(true);

        //Act
        Func<Task> action = async () => await _ticketService.CreateTicketCudAsync(requestData);

        //Assert
        await action.Should().ThrowAsync<TicketAlreadyOpenException>();

    }

    [Fact]
    public async Task CreateTicketCudAsync_WhenUploadImageFails_ThrowsDocumentException()
    {
        //Arrange
        var requestData = CreateTicketCudData();

        _ticketRepositoryMock.Setup(t => t.TicketOpenExistAsync(requestData.UserId, TicketTypeEnum.CUD)).ReturnsAsync(false);
        _documentServiceMock.Setup(d => d.UploadImageAsync(requestData.Documents)).ThrowsAsync(new DocumentUploadException());

        // Act
        Func<Task> action = async () => await _ticketService.CreateTicketCudAsync(requestData);

        // Assert
        await action.Should().ThrowAsync<DocumentUploadException>();
    }

    #endregion

    #region SUBE
    [Fact]
    public async Task Service_ShouldReturnCreateTicketSubeData_WhenDataIsValid()
    {
        //Arrange
        var requestData = CreateTicketSubeData();
        var documentData = CreateDocumentsData();
        var agentId = Guid.NewGuid();
        var ticket = CreateTicket();

        _ticketRepositoryMock.Setup(t => t.TicketOpenExistAsync(requestData.UserId, TicketTypeEnum.SUBE)).ReturnsAsync(false);
        _documentServiceMock.Setup(d => d.UploadImageAsync(requestData.Documents)).ReturnsAsync(documentData);
        _backofficeClientMock.Setup(d => d.GetNextAvailableAgentAsync("SUBE")).ReturnsAsync(agentId);
        _ticketRepositoryMock.Setup(t => t.CreateTicketSubeAsync(requestData)).ReturnsAsync(ticket);
        _mapperMock.Setup(m => m.Map<CreateTicketSubeData>(ticket)).Returns(requestData);

        //Act
        var response = await _ticketService.CreateTicketSubeAsync(requestData);

        //Assert
        response.Should().NotBeNull();
        response.TicketCode.Should().Be("TICKET123");
    }

    [Fact]
    public async Task CreateTicketSubeAsync_WhenTicketAlreadyOpen_ThrowsTicketAlreadyOpenException()
    {
        //Arrange
        var requestData = CreateTicketSubeData();

        _ticketRepositoryMock.Setup(t => t.TicketOpenExistAsync(requestData.UserId, TicketTypeEnum.SUBE)).ReturnsAsync(true);

        //Act
        Func<Task> action = async () => await _ticketService.CreateTicketSubeAsync(requestData);

        //Assert
        await action.Should().ThrowAsync<TicketAlreadyOpenException>();

    }

    [Fact]
    public async Task CreateTicketSubeAsync_WhenUploadImageFails_ThrowsDocumentException()
    {
        //Arrange
        var requestData = CreateTicketSubeData();

        _ticketRepositoryMock.Setup(t => t.TicketOpenExistAsync(requestData.UserId, TicketTypeEnum.SUBE)).ReturnsAsync(false);
        _documentServiceMock.Setup(d => d.UploadImageAsync(requestData.Documents)).ThrowsAsync(new DocumentUploadException());

        // Act
        Func<Task> action = async () => await _ticketService.CreateTicketSubeAsync(requestData);

        // Assert
        await action.Should().ThrowAsync<DocumentUploadException>();
    }

    #endregion

    #region PARKING

    [Fact]
    public async Task Service_ShouldReturnCreateTicketParkingData_WhenDataIsValid()
    {
        //Arrange
        var requestData = CreateTicketParkingData();
        var documentData = CreateDocumentsData();
        var agentId = Guid.NewGuid();
        var ticket = CreateTicket();

        _ticketRepositoryMock.Setup(t => t.TicketOpenExistAsync(requestData.UserId, TicketTypeEnum.SUBE)).ReturnsAsync(false);
        _documentServiceMock.Setup(d => d.UploadImageAsync(requestData.Documents)).ReturnsAsync(documentData);
        _backofficeClientMock.Setup(d => d.GetNextAvailableAgentAsync("Parking")).ReturnsAsync(agentId);
        _ticketRepositoryMock.Setup(t => t.CreateTicketParkingAsync(requestData)).ReturnsAsync(ticket);
        _mapperMock.Setup(m => m.Map<CreateTicketParkingData>(ticket)).Returns(requestData);

        //Act
        var response = await _ticketService.CreateTicketParkingAsync(requestData);

        //Assert
        response.Should().NotBeNull();
        response.TicketCode.Should().Be("TICKET123");
    }

    [Fact]
    public async Task CreateTicketParkingAsync_WhenTicketAlreadyOpen_ThrowsTicketAlreadyOpenException()
    {
        //Arrange
        var requestData = CreateTicketParkingData();

        _ticketRepositoryMock.Setup(t => t.TicketOpenExistAsync(requestData.UserId, TicketTypeEnum.PARKING)).ReturnsAsync(true);

        //Act
        Func<Task> action = async () => await _ticketService.CreateTicketParkingAsync(requestData);

        //Assert
        await action.Should().ThrowAsync<TicketAlreadyOpenException>();

    }

    [Fact]
    public async Task CreateTicketParkingAsync_WhenUploadImageFails_ThrowsDocumentException()
    {
        //Arrange
        var requestData = CreateTicketParkingData();

        _ticketRepositoryMock.Setup(t => t.TicketOpenExistAsync(requestData.UserId, TicketTypeEnum.PARKING)).ReturnsAsync(false);
        _documentServiceMock.Setup(d => d.UploadImageAsync(requestData.Documents)).ThrowsAsync(new DocumentUploadException());

        // Act
        Func<Task> action = async () => await _ticketService.CreateTicketParkingAsync(requestData);

        // Assert
        await action.Should().ThrowAsync<DocumentUploadException>();
    }

    #endregion

    #endregion

    #region GET METHODS

    #region CUD - USERS

    [Fact]
    public async Task GetTicketCudUserAsync_ShouldReturnTicket_WhenTicketExists()
    {

        var request = GetTicketCudUserRequestObject();
        var getTicketCudData = GetTicketCudData();
        var ticketCud = GetTicketCud();

        _ticketRepositoryMock
            .Setup(repo => repo.GetTicketCudUserAsync(request.UserId, request.TicketId, request.TicketCode))
            .ReturnsAsync(ticketCud);

        _mapperMock.
            Setup(m => m.Map<GetTicketCudData>(ticketCud)).Returns(getTicketCudData);

        _authenticationClientMock
            .Setup(client => client.GetUserDataAsync(getTicketCudData.Ticket.UserId))
            .ReturnsAsync(new UserData());

        _backofficeClientMock
            .Setup(client => client.GetAgentDataAsync(getTicketCudData.Ticket.AssignedAgentId.Value))
            .ReturnsAsync(new AgentData());

        // Act
        var result = await _ticketService.GetTicketCudUserAsync(request.UserId, request.TicketId, request.TicketCode);

        // Assert
        result.Should().NotBeNull();
        result.Ticket.Should().NotBeNull();
        result.Ticket.UserData.Should().NotBeNull();
        result.Ticket.AgentData.Should().NotBeNull();
        result.Ticket.AssignedAgentId.Should().Be(getTicketCudData.Ticket.AssignedAgentId);
    }

    [Fact]
    public async Task GetTicketCudUserAsync_ShouldThrowTicketNotFoundException_WhenTicketNotFound()
    {
        var request = GetTicketCudUserRequestObject();
        var responseData = GetTicketCud();

        _ticketRepositoryMock
            .Setup(repo => repo.GetTicketCudUserAsync(request.UserId, request.TicketId, request.TicketCode))
            .ThrowsAsync(new TicketNotFoundException());

        // Act
        Func<Task> action = async () => await _ticketService.GetTicketCudUserAsync(request.UserId, request.TicketId, request.TicketCode);

        // Assert
        await action.Should().ThrowAsync<TicketNotFoundException>();
    }

    #endregion

    #region CUD - AGENT
    [Fact]
    public async Task GetTicketCudAgentAsync_ShouldReturnTicket_WhenTicketExists()
    {

        var request = GetTicketCudUserRequestObject();
        var getTicketCudData = GetTicketCudData();
        var ticketCud = GetTicketCud();

        _ticketRepositoryMock
            .Setup(repo => repo.GetTicketCudAgentAsync(request.TicketId, request.TicketCode))
            .ReturnsAsync(ticketCud);

        _mapperMock.
            Setup(m => m.Map<GetTicketCudData>(ticketCud)).Returns(getTicketCudData);

        _authenticationClientMock
            .Setup(client => client.GetUserDataAsync(getTicketCudData.Ticket.UserId))
            .ReturnsAsync(new UserData());

        _backofficeClientMock
            .Setup(client => client.GetAgentDataAsync(getTicketCudData.Ticket.AssignedAgentId.Value))
            .ReturnsAsync(new AgentData());

        // Act
        var result = await _ticketService.GetTicketCudAgentAsync(request.TicketId, request.TicketCode);

        // Assert
        result.Should().NotBeNull();
        result.Ticket.Should().NotBeNull();
        result.Ticket.UserData.Should().NotBeNull();
        result.Ticket.AgentData.Should().NotBeNull();
        result.Ticket.AssignedAgentId.Should().Be(getTicketCudData.Ticket.AssignedAgentId);
    }

    [Fact]
    public async Task GetTicketCudAgentAsync_ShouldThrowTicketNotFoundException_WhenTicketNotFound()
    {
        var request = GetTicketCudUserRequestObject();
        var responseData = GetTicketCud();

        _ticketRepositoryMock
            .Setup(repo => repo.GetTicketCudAgentAsync(request.TicketId, request.TicketCode))
            .ThrowsAsync(new TicketNotFoundException());

        // Act
        Func<Task> action = async () => await _ticketService.GetTicketCudAgentAsync(request.TicketId, request.TicketCode);

        // Assert
        await action.Should().ThrowAsync<TicketNotFoundException>();
    }

    #endregion

    #region SUBE - USERS

    [Fact]
    public async Task GetTicketSubeUserAsync_ShouldReturnTicket_WhenTicketExists()
    {

        var request = GetTicketSubeUsersRequestObject();
        var getTicketSubeData = GetTicketSubeData();
        var ticketSube = GetTicketSube();

        _ticketRepositoryMock
            .Setup(repo => repo.GetTicketSubeUserAsync(request.UserId, request.TicketId, request.TicketCode))
            .ReturnsAsync(ticketSube);

        _mapperMock.
            Setup(m => m.Map<GetTicketSubeData>(ticketSube)).Returns(getTicketSubeData);

        _authenticationClientMock
            .Setup(client => client.GetUserDataAsync(getTicketSubeData.Ticket.UserId))
            .ReturnsAsync(new UserData());

        _backofficeClientMock
            .Setup(client => client.GetAgentDataAsync(getTicketSubeData.Ticket.AssignedAgentId.Value))
            .ReturnsAsync(new AgentData());

        // Act
        var result = await _ticketService.GetTicketSubeUserAsync(request.UserId, request.TicketId, request.TicketCode);

        // Assert
        result.Should().NotBeNull();
        result.Ticket.Should().NotBeNull();
        result.Ticket.UserData.Should().NotBeNull();
        result.Ticket.AgentData.Should().NotBeNull();
        result.Ticket.AssignedAgentId.Should().Be(getTicketSubeData.Ticket.AssignedAgentId);
    }

    [Fact]
    public async Task GetTicketSubeUserAsync_ShouldThrowTicketNotFoundException_WhenTicketNotFound()
    {
        var request = GetTicketSubeUsersRequestObject();
        var responseData = GetTicketSube();

        _ticketRepositoryMock
            .Setup(repo => repo.GetTicketSubeUserAsync(request.UserId, request.TicketId, request.TicketCode))
            .ThrowsAsync(new TicketNotFoundException());

        // Act
        Func<Task> action = async () => await _ticketService.GetTicketSubeUserAsync(request.UserId, request.TicketId, request.TicketCode);

        // Assert
        await action.Should().ThrowAsync<TicketNotFoundException>();
    }

    #endregion

    #region SUBE - AGENT
    [Fact]
    public async Task GetTicketSubeAgentAsync_ShouldReturnTicket_WhenTicketExists()
    {

        var request = GetTicketSubeAgentsRequestObject();
        var getTicketSubeData = GetTicketSubeData();
        var ticketSube = GetTicketSube();

        _ticketRepositoryMock
            .Setup(repo => repo.GetTicketSubeAgentAsync(request.TicketId, request.TicketCode))
            .ReturnsAsync(ticketSube);

        _mapperMock.
            Setup(m => m.Map<GetTicketSubeData>(ticketSube)).Returns(getTicketSubeData);

        _authenticationClientMock
            .Setup(client => client.GetUserDataAsync(getTicketSubeData.Ticket.UserId))
            .ReturnsAsync(new UserData());

        _backofficeClientMock
            .Setup(client => client.GetAgentDataAsync(getTicketSubeData.Ticket.AssignedAgentId.Value))
            .ReturnsAsync(new AgentData());

        // Act
        var result = await _ticketService.GetTicketSubeAgentAsync(request.TicketId, request.TicketCode);

        // Assert
        result.Should().NotBeNull();
        result.Ticket.Should().NotBeNull();
        result.Ticket.UserData.Should().NotBeNull();
        result.Ticket.AgentData.Should().NotBeNull();
        result.Ticket.AssignedAgentId.Should().Be(getTicketSubeData.Ticket.AssignedAgentId);
    }

    [Fact]
    public async Task GetTicketSubeAgentAsync_ShouldThrowTicketNotFoundException_WhenTicketNotFound()
    {
        var request = GetTicketSubeUsersRequestObject();
        var responseData = GetTicketSube();

        _ticketRepositoryMock
            .Setup(repo => repo.GetTicketSubeAgentAsync(request.TicketId, request.TicketCode))
            .ThrowsAsync(new TicketNotFoundException());

        // Act
        Func<Task> action = async () => await _ticketService.GetTicketSubeAgentAsync(request.TicketId, request.TicketCode);

        // Assert
        await action.Should().ThrowAsync<TicketNotFoundException>();
    }

    #endregion

    #region PARKING - USERS

    [Fact]
    public async Task GetTicketParkingUserAsync_ShouldReturnTicket_WhenTicketExists()
    {

        var request = GetTicketParkingUsersRequestObject();
        var getTicketParkingData = GetTicketParkingData();
        var ticketParking = GetTicketParking();

        _ticketRepositoryMock
            .Setup(repo => repo.GetTicketParkingUserAsync(request.UserId, request.TicketId, request.TicketCode))
            .ReturnsAsync(ticketParking);

        _mapperMock.
            Setup(m => m.Map<GetTicketParkingData>(ticketParking)).Returns(getTicketParkingData);

        _authenticationClientMock
            .Setup(client => client.GetUserDataAsync(getTicketParkingData.Ticket.UserId))
            .ReturnsAsync(new UserData());

        _backofficeClientMock
            .Setup(client => client.GetAgentDataAsync(getTicketParkingData.Ticket.AssignedAgentId.Value))
            .ReturnsAsync(new AgentData());

        // Act
        var result = await _ticketService.GetTicketParkingUserAsync(request.UserId, request.TicketId, request.TicketCode);

        // Assert
        result.Should().NotBeNull();
        result.Ticket.Should().NotBeNull();
        result.Ticket.UserData.Should().NotBeNull();
        result.Ticket.AgentData.Should().NotBeNull();
        result.Ticket.AssignedAgentId.Should().Be(getTicketParkingData.Ticket.AssignedAgentId);
    }

    [Fact]
    public async Task GetTicketParkingUserAsync_ShouldThrowTicketNotFoundException_WhenTicketNotFound()
    {
        var request = GetTicketParkingUsersRequestObject();
        var responseData = GetTicketParking();

        _ticketRepositoryMock
            .Setup(repo => repo.GetTicketParkingUserAsync(request.UserId, request.TicketId, request.TicketCode))
            .ThrowsAsync(new TicketNotFoundException());

        // Act
        Func<Task> action = async () => await _ticketService.GetTicketParkingUserAsync(request.UserId, request.TicketId, request.TicketCode);

        // Assert
        await action.Should().ThrowAsync<TicketNotFoundException>();
    }

    #endregion

    #region PARKING - AGENT
    [Fact]
    public async Task GetTicketParkingAgentAsync_ShouldReturnTicket_WhenTicketExists()
    {

        var request = GetTicketParkingAgentRequestObject();
        var getTicketParkingData = GetTicketParkingData();
        var ticketParking = GetTicketParking();

        _ticketRepositoryMock
            .Setup(repo => repo.GetTicketParkingAgentAsync(request.TicketId, request.TicketCode))
            .ReturnsAsync(ticketParking);

        _mapperMock.
            Setup(m => m.Map<GetTicketParkingData>(ticketParking)).Returns(getTicketParkingData);

        _authenticationClientMock
            .Setup(client => client.GetUserDataAsync(getTicketParkingData.Ticket.UserId))
            .ReturnsAsync(new UserData());

        _backofficeClientMock
            .Setup(client => client.GetAgentDataAsync(getTicketParkingData.Ticket.AssignedAgentId.Value))
            .ReturnsAsync(new AgentData());

        // Act
        var result = await _ticketService.GetTicketParkingAgentAsync(request.TicketId, request.TicketCode);

        // Assert
        result.Should().NotBeNull();
        result.Ticket.Should().NotBeNull();
        result.Ticket.UserData.Should().NotBeNull();
        result.Ticket.AgentData.Should().NotBeNull();
        result.Ticket.AssignedAgentId.Should().Be(getTicketParkingData.Ticket.AssignedAgentId);
    }

    [Fact]
    public async Task GetTicketParkingAgentAsync_ShouldThrowTicketNotFoundException_WhenTicketNotFound()
    {
        var request = GetTicketParkingAgentRequestObject();
        var responseData = GetTicketParking();

        _ticketRepositoryMock
            .Setup(repo => repo.GetTicketParkingAgentAsync(request.TicketId, request.TicketCode))
            .ThrowsAsync(new TicketNotFoundException());

        // Act
        Func<Task> action = async () => await _ticketService.GetTicketParkingAgentAsync(request.TicketId, request.TicketCode);

        // Assert
        await action.Should().ThrowAsync<TicketNotFoundException>();
    }

    #endregion

    #endregion

    #region LIST METHODS

    [Fact]
    public async Task ListTicketsUserAsync_ShouldReturnMappedTickets_WhenTicketsExist()
    {
        //ARRANGE
        var userId = Guid.NewGuid();
        var ticketListData = CreateTicketListData();
        var ticketList = CreateTicketList();

        _mapperMock.Setup(m => m.Map<ListTicketData[]>(ticketList)).Returns(ticketListData);
        _ticketRepositoryMock.Setup(t => t.ListTicketsAsync(userId)).ReturnsAsync(ticketList);

        //Act
        var result = await _ticketService.ListTicketsUserAsync(userId);

        //Assert
        result.Should().NotBeNull();
        result.Should().HaveCount(3);

    }

    [Fact]
    public async Task ListTicketsUserAsync_ShouldReturnEmptyArray_WhenNoTicketsFound()
    {
        //ARRANGE
        var userId = Guid.NewGuid();
        var ticketListData = CreateTicketListData();
        var ticketList = CreateTicketList();

        _mapperMock.Setup(m => m.Map<ListTicketData[]>(ticketList)).Returns([]);
        _ticketRepositoryMock.Setup(t => t.ListTicketsAsync(userId)).ReturnsAsync([]);

        //Act
        var result = await _ticketService.ListTicketsUserAsync(userId);

        //Assert
        result.Should().NotBeNull();
        result.Should().HaveCount(0);
    }

    [Fact]
    public async Task ListTicketsAgentAsync_ShouldReturnMappedTickets_WhenTicketsExist()
    {
        //ARRANGE
        var filters = CreateFiltersData();
        var ticketListData = CreateTicketListData();
        var ticketList = CreateTicketList();

        _mapperMock.Setup(m => m.Map<ListTicketData[]>(ticketList)).Returns(ticketListData);
        _ticketRepositoryMock.Setup(t => t.ListTicketsAsync(filters.AgentId, filters.TicketTypeId, filters.TicketStatusId, filters.PageSize, filters.PageNumber, filters.UserIds, filters.TicketCode)).ReturnsAsync(ticketList);

        //Act
        var result = await _ticketService.ListTicketAgentAsync(filters);

        //Assert
        result.Should().NotBeNull();
        result.Should().HaveCount(3);

    }

    [Fact]
    public async Task ListTicketsAgentAsync_ShouldReturnEmptyArray_WhenNoTicketsFound()
    {
        //ARRANGE
        var filters = CreateFiltersData();
        var ticketListData = CreateTicketListData();
        var ticketList = CreateTicketList();

        _mapperMock.Setup(m => m.Map<ListTicketData[]>(ticketList)).Returns([]);
        _ticketRepositoryMock.Setup(t => t.ListTicketsAsync(filters.AgentId, filters.TicketTypeId, filters.TicketStatusId, filters.PageSize, filters.PageNumber, filters.UserIds, filters.TicketCode)).ReturnsAsync([]);

        //Act
        var result = await _ticketService.ListTicketAgentAsync(filters);

        //Assert
        result.Should().NotBeNull();
        result.Should().HaveCount(0);
    }

    [Fact]
    public async Task CountTicketsAgentAsync_ShouldReturnListCountTicketByAgent()
    {
        //ARRANGE
        var filters = CreateFiltersData();
        var countTicketData = CountTicketByAgentData();

        _ticketRepositoryMock.Setup(t => t.CountTicketByAgentAsync()).ReturnsAsync(countTicketData);

        //Act
        var result = await _ticketService.CountTicketByAgentAsync();

        //Assert
        result.Should().NotBeNull();
        result.Should().HaveCount(2);
    }

    [Fact]
    public async Task CountTicketsByFiltersAsync_ShouldReturnListCountTicketByFilters()
    {
        //ARRANGE
        var filters = CreateFiltersData();

        _ticketRepositoryMock.Setup(t => t.CountTicketsByFiltersAsync(filters.AgentId, filters.TicketTypeId, filters.TicketStatusId, filters.PageSize, filters.PageNumber, filters.UserIds, filters.TicketCode)).ReturnsAsync(6);

        //Act
        var result = await _ticketService.CountTicketsByfilterAsync(filters);

        //Assert
        result.Should().Be(6);
    }
    #endregion

    #region UPDATE METHODS

    #region UPDATE CUD
    [Fact]
    public async Task UpdateTicketCudAsync_ShouldReturnSuccess_WhenDataIsValid()
    {
        //Arrange
        var updateData = UpdateTicketCudData();
        var ticketCud = GetTicketCud();

        _ticketRepositoryMock
          .Setup(r => r.UpdateTicketCudAsync(updateData))
          .ReturnsAsync(ticketCud);

        //Act
        Func<Task> act = async () => await _ticketService.UpdateTicketCudAsync(updateData);

        // Assert
        await act.Should().NotThrowAsync();
    }

    [Fact]
    public async Task UpdateTicketCudAsync_ShouldThrowInvalidMedicalCommitteDateException_WhenDateIsInvalid()
    {
        // Arrange
        var updateData = UpdateTicketCudData();
        updateData.MedicalCommitteDate = DateTime.Today.AddDays(-1);
        // Act
        Func<Task> act = async () => await _ticketService.UpdateTicketCudAsync(updateData);

        // Assert
        await act.Should().ThrowAsync<InvalidMedicalCommitteDateException>();
        _ticketRepositoryMock.Verify(r => r.UpdateTicketCudAsync(updateData), Times.Never);
    }

    [Fact]
    public async Task UpdateTicketCudAsync_ShouldThrowTicketNotFoundException_WhenRepositoryThrowsException()
    {
        // Arrange
        var updateData = UpdateTicketCudData();


        _ticketRepositoryMock
            .Setup(r => r.UpdateTicketCudAsync(updateData))
            .ThrowsAsync(new TicketNotFoundException());

        // Act
        Func<Task> act = async () => await _ticketService.UpdateTicketCudAsync(updateData);

        // Assert
        await act.Should().ThrowAsync<TicketNotFoundException>();
        _emailServiceMock.Verify(e => e.SendEmailHandlerAsync(It.IsAny<string>(), It.IsAny<string>(), ""), Times.Never);
    }

    [Fact]
    public async Task UpdateTicketCudAsync_ShouldThrowDocumentStatusNotFoundException_WhenRepositoryThrowsException()
    {
        // Arrange
        var updateData = UpdateTicketCudData();


        _ticketRepositoryMock
            .Setup(r => r.UpdateTicketCudAsync(updateData))
            .ThrowsAsync(new DocumentStatusNotFoundException());

        // Act
        Func<Task> act = async () => await _ticketService.UpdateTicketCudAsync(updateData);

        // Assert
        await act.Should().ThrowAsync<DocumentStatusNotFoundException>();
        _emailServiceMock.Verify(e => e.SendEmailHandlerAsync(It.IsAny<string>(), It.IsAny<string>(), ""), Times.Never);
    }

    #endregion

    #region UPDATE SUBE
    [Fact]
    public async Task UpdateTicketSubeAsync_ShouldReturnSuccess_WhenDataIsValid()
    {
        //Arrange
        var updateData = UpdateTicketSubeData();
        var ticketSube = GetTicketSube();

        _ticketRepositoryMock
          .Setup(r => r.UpdateTicketSubeAsync(updateData))
          .ReturnsAsync(ticketSube);

        //Act
        Func<Task> act = async () => await _ticketService.UpdateTicketSubeAsync(updateData);

        // Assert
        await act.Should().NotThrowAsync();
    }

    [Fact]
    public async Task UpdateTicketSubeAsync_ShouldThrowTicketNotFoundException_WhenRepositoryThrowsException()
    {
        // Arrange
        var updateData = UpdateTicketSubeData();

        _ticketRepositoryMock
            .Setup(r => r.UpdateTicketSubeAsync(updateData))
            .ThrowsAsync(new TicketNotFoundException());

        // Act
        Func<Task> act = async () => await _ticketService.UpdateTicketSubeAsync(updateData);

        // Assert
        await act.Should().ThrowAsync<TicketNotFoundException>();
        _emailServiceMock.Verify(e => e.SendEmailHandlerAsync(It.IsAny<string>(), It.IsAny<string>(), ""), Times.Never);
    }

    [Fact]
    public async Task UpdateTicketSubeAsync_ShouldThrowDocumentStatusNotFoundException_WhenRepositoryThrowsException()
    {
        // Arrange
        var updateData = UpdateTicketSubeData();


        _ticketRepositoryMock
            .Setup(r => r.UpdateTicketSubeAsync(updateData))
            .ThrowsAsync(new DocumentStatusNotFoundException());

        // Act
        Func<Task> act = async () => await _ticketService.UpdateTicketSubeAsync(updateData);

        // Assert
        await act.Should().ThrowAsync<DocumentStatusNotFoundException>();
        _emailServiceMock.Verify(e => e.SendEmailHandlerAsync(It.IsAny<string>(), It.IsAny<string>(), ""), Times.Never);
    }

    #endregion

    #region UPDATE PARKING
    [Fact]
    public async Task UpdateTicketParkingAsync_ShouldReturnSuccess_WhenDataIsValid()
    {
        //Arrange
        var updateData = UpdateTicketParkingData();
        var ticketParking = GetTicketParking();

        _ticketRepositoryMock
          .Setup(r => r.UpdateTicketParkingAsync(updateData))
          .ReturnsAsync(ticketParking);

        //Act
        Func<Task> act = async () => await _ticketService.UpdateTicketParkingAsync(updateData);

        // Assert
        await act.Should().NotThrowAsync();
    }

    [Fact]
    public async Task UpdateTicketParkingAsync_ShouldThrowTicketNotFoundException_WhenRepositoryThrowsException()
    {
        // Arrange
        var updateData = UpdateTicketParkingData();

        _ticketRepositoryMock
            .Setup(r => r.UpdateTicketParkingAsync(updateData))
            .ThrowsAsync(new TicketNotFoundException());

        // Act
        Func<Task> act = async () => await _ticketService.UpdateTicketParkingAsync(updateData);

        // Assert
        await act.Should().ThrowAsync<TicketNotFoundException>();
        _emailServiceMock.Verify(e => e.SendEmailHandlerAsync(It.IsAny<string>(), It.IsAny<string>(), ""), Times.Never);
    }

    [Fact]
    public async Task UpdateTicketParkingAsync_ShouldThrowDocumentStatusNotFoundException_WhenRepositoryThrowsException()
    {
        // Arrange
        var updateData = UpdateTicketParkingData();


        _ticketRepositoryMock
            .Setup(r => r.UpdateTicketParkingAsync(updateData))
            .ThrowsAsync(new DocumentStatusNotFoundException());

        // Act
        Func<Task> act = async () => await _ticketService.UpdateTicketParkingAsync(updateData);

        // Assert
        await act.Should().ThrowAsync<DocumentStatusNotFoundException>();
        _emailServiceMock.Verify(e => e.SendEmailHandlerAsync(It.IsAny<string>(), It.IsAny<string>(), ""), Times.Never);
    }

    #endregion

    #region UPDATE TICKET STATUS
    [Fact]
    public async Task UpdateAllTicketStatusesAsync_ShouldUpdateStatuses_WhenDataIsValid()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var ticketStatusId = 1;

        _ticketRepositoryMock
            .Setup(r => r.UpdateAllTicketStatusesAsync(userId, ticketStatusId))
            .Returns(Task.CompletedTask);

        // Act
        Func<Task> act = async () => await _ticketService.UpdateAllTicketStatusesAsync(userId, ticketStatusId);

        // Assert
        await act.Should().NotThrowAsync();

        _ticketRepositoryMock.Verify(r => r.UpdateAllTicketStatusesAsync(userId, ticketStatusId), Times.Once);
    }

    [Fact]
    public async Task UpdateAllTicketStatusesAsync_ShouldThrowTicketNotFoundException_WhenTicketDoesNotExist()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var ticketStatusId = 1;

        _ticketRepositoryMock
            .Setup(r => r.UpdateAllTicketStatusesAsync(userId, ticketStatusId))
            .ThrowsAsync(new TicketNotFoundException());

        // Act
        Func<Task> act = async () => await _ticketService.UpdateAllTicketStatusesAsync(userId, ticketStatusId);

        // Assert
        await act.Should().ThrowAsync<TicketNotFoundException>();

        _ticketRepositoryMock.Verify(r => r.UpdateAllTicketStatusesAsync(userId, ticketStatusId), Times.Once);
    }

    #endregion

    #region CANCEL TICKETS
    [Fact]
    public async Task CancelTicketAsync_ShouldCancelTicket_WhenDataIsValid()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var ticketId = Guid.NewGuid();

        _ticketRepositoryMock
            .Setup(r => r.CancelTicket(userId, ticketId))
            .Returns(Task.CompletedTask);

        // Act
        Func<Task> act = async () => await _ticketService.CancelTicketAsync(userId, ticketId);

        // Assert
        await act.Should().NotThrowAsync();

        _ticketRepositoryMock.Verify(r => r.CancelTicket(userId, ticketId), Times.Once);
    }

    [Fact]
    public async Task CancelTicketAsync_ShouldThrowTicketNotFoundException_WhenTicketDoesNotExist()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var ticketId = Guid.NewGuid();

        _ticketRepositoryMock
            .Setup(r => r.CancelTicket(userId, ticketId))
            .ThrowsAsync(new TicketNotFoundException());

        // Act
        Func<Task> act = async () => await _ticketService.CancelTicketAsync(userId, ticketId);

        // Assert
        await act.Should().ThrowAsync<TicketNotFoundException>();

        _ticketRepositoryMock.Verify(r => r.CancelTicket(userId, ticketId), Times.Once);
    }
    #endregion

    #region REASSIGN METHODS
    [Fact]
    public async Task ReassignTicketAsync_ShouldReassignTickets_WhenAgentHasTickets()
    {
        // Arrange
        var agentId = Guid.NewGuid();
        var ticketTypeName = "ExampleType";

        var tickets = new List<Ticket>
        {
            new Ticket { Id = Guid.NewGuid(), TicketType = new TicketType { Name = ticketTypeName }, AssignedAgentId = agentId },
            new Ticket { Id = Guid.NewGuid(), TicketType = new TicketType { Name = ticketTypeName }, AssignedAgentId = agentId }
        };

        var newAgentId = Guid.NewGuid();

        _ticketRepositoryMock
            .Setup(r => r.ListTicketAssigned(agentId))
            .ReturnsAsync(tickets);

        _backofficeClientMock
            .Setup(c => c.GetNextAvailableAgentAsync(ticketTypeName))
            .ReturnsAsync(newAgentId);

        _ticketRepositoryMock
            .Setup(r => r.SaveChangesAsync(It.IsAny<List<Ticket>>()))
            .Returns(Task.CompletedTask);

        // Act
        await _ticketService.ReassignTicketAsync(agentId);

        // Assert
        foreach (var ticket in tickets)
        {
            ticket.AssignedAgentId.Should().Be(newAgentId);
            ticket.AgentId.Should().Be(newAgentId);
        }

        _ticketRepositoryMock.Verify(r => r.SaveChangesAsync(tickets), Times.Once);
    }

    [Fact]
    public async Task ReassignTicketAsync_ShouldReassignTicket_WhenDataIsValid()
    {
        // Arrange
        var ticketId = Guid.NewGuid();
        var agentId = Guid.NewGuid();
        var supervisorId = Guid.NewGuid();

        _ticketRepositoryMock
            .Setup(r => r.ReassignTicketAsync(ticketId, agentId))
            .Returns(Task.CompletedTask);

        // Act
        Func<Task> act = async () => await _ticketService.ReassignTicketAsync(ticketId, agentId, supervisorId);

        // Assert
        await act.Should().NotThrowAsync();

        _ticketRepositoryMock.Verify(r => r.ReassignTicketAsync(ticketId, agentId), Times.Once);
    }

    [Fact]
    public async Task ReassignTicketAsync_ShouldThrowTicketNotFoundException_WhenTicketDoesNotExist()
    {
        // Arrange
        var ticketId = Guid.NewGuid();
        var agentId = Guid.NewGuid();
        var supervisorId = Guid.NewGuid();

        _ticketRepositoryMock
            .Setup(r => r.ReassignTicketAsync(ticketId, agentId))
            .ThrowsAsync(new TicketNotFoundException());

        // Act
        Func<Task> act = async () => await _ticketService.ReassignTicketAsync(ticketId, agentId, supervisorId);

        // Assert
        await act.Should().ThrowAsync<TicketNotFoundException>();

        _ticketRepositoryMock.Verify(r => r.ReassignTicketAsync(ticketId, agentId), Times.Once);
    }

    #endregion

    #endregion

    #region VALIDATE METHODS

    [Fact]
    public async Task TicketExitsAsync_ShouldReturnTrue_WhenTicketExists()
    {
        // Arrange
        var ticketId = Guid.NewGuid();
        _ticketRepositoryMock
            .Setup(r => r.TicketExistAsync(ticketId))
            .ReturnsAsync(true);

        // Act
        var result = await _ticketService.TicketExitsAsync(ticketId);

        // Assert
        result.Should().BeTrue();
        _ticketRepositoryMock.Verify(r => r.TicketExistAsync(ticketId), Times.Once);
    }

    [Fact]
    public async Task TicketExitsAsync_ShouldReturnFalse_WhenTicketDoesNotExist()
    {
        // Arrange
        var ticketId = Guid.NewGuid();
        _ticketRepositoryMock
            .Setup(r => r.TicketExistAsync(ticketId))
            .ReturnsAsync(false);

        // Act
        var result = await _ticketService.TicketExitsAsync(ticketId);

        // Assert
        result.Should().BeFalse();
        _ticketRepositoryMock.Verify(r => r.TicketExistAsync(ticketId), Times.Once);
    }

#endregion

#region SEEDS DATA

#region CREATE TICKET DATA
private static CreateTicketCudData CreateTicketCudData()
    {
        return new CreateTicketCudData
        {
            Email = "test@example.com",
            TicketCode = "TICKET123",
            TicketStatusId = 1,
            Certificate = true,
            ExpiredCertificate = false,
            CertificateExpansionOptionsId = 1,
            LostCertificate = false,
            HealthInsurance = true,
            PaySlip = true,
            SignatureOptionId = 1,
            DocumentComplete = true,
            Documents = [
                new() { DocumentImage = "BASE64ADASD",
                        DocumentStatusId = 1,
                        DocumentTypeId = 1 },

                new() { DocumentImage = "BASE64ADASD3",
                        DocumentStatusId = 1,
                        DocumentTypeId = 2 },
            ]
        };
    }

    private static CreateTicketSubeData CreateTicketSubeData()
    {
        return new CreateTicketSubeData
        {
            Email = "test@example.com",
            TicketCode = "TICKET123",
            TicketStatusId = 1,
            Documents = []
        };
    }

    private static CreateTicketParkingData CreateTicketParkingData()
    {
        return new CreateTicketParkingData
        {
            Email = "test@example.com",
            TicketCode = "TICKET123",
            TicketStatusId = 1,
            Documents = []
        };
    }

    private static List<DocumentData> CreateDocumentsData()
    {
        return [
            new() { DocumentImage = "URL",
                    DocumentStatusId = 1,
                    DocumentTypeId = 1 },

            new() { DocumentImage = "URLTWO",
                    DocumentStatusId = 1,
                    DocumentTypeId = 2 },

        ];
    }

    #endregion

    #region REQUESTS
    private static GetTicketCudAgentRequest GetTicketCudAgentsRequestObject()
    {
        return new GetTicketCudAgentRequest
        {
            TicketCode = "DS-DIS-039",
            TicketId = Guid.NewGuid()
        };
    }

    private static GetTicketCudUserRequest GetTicketCudUserRequestObject()
    {
        return new GetTicketCudUserRequest
        {
            TicketCode = "DS-DIS-039",
            TicketId = Guid.Parse("64d47c97-59d2-4505-bab0-8aaa6fdc5212"),
            UserId = Guid.Parse("ee7fc2e2-27f1-4dba-b31f-1e98eaaa4f70")
        };
    }

    private static GetTicketSubeAgentRequest GetTicketSubeAgentsRequestObject()
    {
        return new GetTicketSubeAgentRequest
        {
            TicketCode = "DS-DIS-011",
            TicketId = Guid.Parse("64d47c97-59d2-4505-bab0-8aaa6fdc5213"),
        };
    }

    private static GetTicketSubeUserRequest GetTicketSubeUsersRequestObject()
    {
        return new GetTicketSubeUserRequest
        {
            TicketCode = "DS-DIS-011",
            TicketId = Guid.Parse("64d47c97-59d2-4505-bab0-8aaa6fdc5213"),
            UserId = Guid.Parse("ee7fc2e2-27f1-4dba-b31f-1e98eaaa4f70")
        };
    }

    private static GetTicketParkingUserRequest GetTicketParkingUsersRequestObject()
    {
        return new GetTicketParkingUserRequest
        {
            TicketCode = "DS-DIS-015",
            TicketId = Guid.Parse("64d47c97-59d2-4505-bab0-8aaa6fdc5215"),
            UserId = Guid.Parse("ee7fc2e2-27f1-4dba-b31f-1e98eaaa4f70")
        };
    }

    private static GetTicketParkingAgentRequest GetTicketParkingAgentRequestObject()
    {
        return new GetTicketParkingAgentRequest
        {
            TicketCode = "DS-DIS-015",
            TicketId = Guid.Parse("64d47c97-59d2-4505-bab0-8aaa6fdc5215"),
        };
    }

    #endregion

    #region GET TICKET DATA
    private static TicketData CreateTicketData()
    {
        return new()
        {
            Id = Guid.Parse("64d47c97-59d2-4505-bab0-8aaa6fdc5212"),
            UserId = Guid.Parse("ee7fc2e2-27f1-4dba-b31f-1e98eaaa4f70"),
            AssignedAgentId = Guid.Parse("18d14490-91c1-4ba6-843c-9b501d187051"),
            Documents = [],
            TicketCode = "TICKET123",
            TicketStatus = null,
            TicketType = null,
            CreationDate = DateTime.Now
        };
    }

    private static GetTicketCudData GetTicketCudData()
    {
        return new()
        {
            Ticket = CreateTicketData(),
            Certificate = true,
            ExpiredCertificate = false,
            CertificateExpansionOptions = new CertificateExpansionOptionsData() { Id = 1, Name = "TEST" },
            LostCertificate = false,
            HealthInsurance = true,
            PaySlip = true,
            SignatureOption = new() { Id = 1, Name = "firma por si mismo" },
            DocumentComplete = true
        };
    }

    private static GetTicketSubeData GetTicketSubeData()
    {
        return new()
        {
            Ticket = CreateTicketData(),
            CudCertificateNumber = "ABCF2",
            CardPickupLocationsOptions = new() { Id = 1, Name = "TEST" }
        };
    }

    private static GetTicketParkingData GetTicketParkingData()
    {
        return new()
        {
            Ticket = CreateTicketData()
        };
    }

    #endregion

    #region LIST METHODS

    private ListTicketData[] CreateTicketListData()
    {
        return [
            new ListTicketData(){ TicketCode = "DS-DIS-1",UserId = Guid.Parse("ee7fc2e2-27f1-4dba-b31f-1e98eaaa4f70") },
            new ListTicketData(){ TicketCode = "DS-DIS-2",UserId = Guid.Parse("ee7fc2e2-27f1-4dba-b31f-1e98eaaa4f70")},
            new ListTicketData(){ TicketCode = "DS-DIS-3",UserId = Guid.Parse("ee7fc2e2-27f1-4dba-b31f-1e98eaaa4f70")},
        ];
    }

    private Ticket[] CreateTicketList()
    {
        return [
            new Ticket(){ TicketCode = "DS-DIS-1",UserId = Guid.Parse("ee7fc2e2-27f1-4dba-b31f-1e98eaaa4f70") },
            new Ticket(){ TicketCode = "DS-DIS-2",UserId = Guid.Parse("ee7fc2e2-27f1-4dba-b31f-1e98eaaa4f70")},
            new Ticket(){ TicketCode = "DS-DIS-3",UserId = Guid.Parse("ee7fc2e2-27f1-4dba-b31f-1e98eaaa4f70")},
        ];
    }

    #endregion

    #region TICKET TABLES

    private static Ticket CreateTicket()
    {
        return new()
        {
            Id = Guid.Parse("64d47c97-59d2-4505-bab0-8aaa6fdc5212"),
            AgentId = Guid.Parse("18d14490-91c1-4ba6-843c-9b501d187051"),
            UserId = Guid.Parse("ee7fc2e2-27f1-4dba-b31f-1e98eaaa4f70"),
            AssignedAgentId = Guid.Parse("18d14490-91c1-4ba6-843c-9b501d187051"),
            Documents = [],
            TicketCode = "TEST",
            TicketStatusId = 1,
            TicketTypeId = 1,
            CreationDate = DateTime.Now
        };
    }

    private static TicketCud GetTicketCud()
    {
        return new()
        {
            Ticket = CreateTicket(),
            Certificate = true,
            ExpiredCertificate = false,
            CertificateExpansionOptionsId = 1,
            LostCertificate = false,
            HealthInsurance = true,
            PaySlip = true,
            SignatureOptionId = 1,
            DocumentComplete = true
        };
    }

    private static TicketSube GetTicketSube()
    {
        return new()
        {
            Ticket = CreateTicket(),
            CudCertificateNumber = "ABCF2",
            CardPickupLocationsOptions = new() { Id = 1, Name = "TEST" }
        };
    }

    private static TicketParking GetTicketParking()
    {
        return new()
        {
            Ticket = CreateTicket()
        };
    }

    #endregion

    #region FILTERS TO LIST

    private ListTicketFiltersDto CreateFiltersData()
    {
        return new ListTicketFiltersDto()
        {
            PageNumber = 1,
            PageSize = 10,
            UserIds = [
                       Guid.Parse("a3692178-542d-4ae2-a273-f3d0d92b6886"),
                       Guid.Parse("556ff509-3b17-4b0b-ae73-6ac189132a3f")
                      ],
            TicketStatusId = 1
        };
    }

    private List<CountTicketByAgentData> CountTicketByAgentData()
    {
        return [
            new()
        {
            Agent = new() { FirstName = "TEST", Id = Guid.Parse("a3692178-542d-4ae2-a273-f3d0d92b6886") },
            AgentId = Guid.Parse("a3692178-542d-4ae2-a273-f3d0d92b6886"),
            TicketStatusQuantity = [new() { Quantity = 2, TicketStatus = new() { Id = 1, Name = "Nuevos" } }]
        },
           new()
        {
            Agent = new() { FirstName = "TEST", Id = Guid.Parse("a3692178-542d-4ae2-a273-f3d0d92b6886") },
            AgentId = Guid.Parse("a3692178-542d-4ae2-a273-f3d0d92b6886"),
            TicketStatusQuantity = [new() { Quantity = 1, TicketStatus = new() { Id = 1, Name = "Finalizados" } }]
        }
        ];
    }

    #endregion

    #region UPDATE DATA
    public UpdateTicketCudData UpdateTicketCudData()
    {
        return new()
        {
            TicketId = Guid.Parse("64d47c97-59d2-4505-bab0-8aaa6fdc5212"),
            TicketStatusId = 2,
            Certificate = true,
            ExpiredCertificate = false,
            CertificateExpansionOptionsId = 1,
            LostCertificate = false,
            HealthInsurance = true,
            PaySlip = true,
            DocumentComplete = true,
            UpdateDocumentStatus = []
        };
    }

    public UpdateTicketSubeData UpdateTicketSubeData()
    {
        return new()
        {
            TicketStatusId = 2,
            CudCertificateNumber = "AVC58",
            TicketId = Guid.Parse("3dd3d868-541d-4275-9146-3b4449ffaa8c"),
            UpdateDocumentStatus = []
        };
    }

    public UpdateTicketParkingData UpdateTicketParkingData()
    {
        return new()
        {
            TicketStatusId = 2,
            TicketId = Guid.Parse("3dd3d868-541d-4275-9146-3b4449ffaa8c"),
            UpdateDocumentStatus = []
        };
    }

    #endregion
    #endregion

}
