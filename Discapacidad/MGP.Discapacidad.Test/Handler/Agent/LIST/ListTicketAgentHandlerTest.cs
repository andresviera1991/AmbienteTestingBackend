using AutoMapper;
using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.List.ListTicketByAgent;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.Domain.interfaces;
using MGP.Discapacidad.Persistance.DTOs.Ticket;
using Moq;
using Xunit;
namespace MGP.Discapacidad.Test.Handler.Agent.LIST;

public class ListTicketAgentHandlerTest
{
    private readonly Mock<ITicketService> _ticketServiceMock;
    private readonly Mock<IValidator<ListTicketAgentRequest>> _validatorMock;
    private readonly Mock<IMapper> _mapperMock;
    private readonly MessageManager _messageManager;
    private readonly ListTicketAgentHandler _handler;

    public ListTicketAgentHandlerTest()
    {
        _ticketServiceMock = new Mock<ITicketService>();
        _validatorMock = new Mock<IValidator<ListTicketAgentRequest>>();
        _mapperMock = new Mock<IMapper>();

        string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
        if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
        _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

        _handler = new ListTicketAgentHandler(
            _ticketServiceMock.Object,
            _validatorMock.Object,
            _messageManager,
            _mapperMock.Object
        );
    }

    [Fact]
    public async Task Handle_Success_ReturnsResponseData()
    {
        // Arrange
        var request = ListTicketAgentRequestObject();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        var ticketData = ListTicketData();
        var filters = ListTicketFiltersDto();

        _mapperMock.Setup(m => m.Map<ListTicketFiltersDto>(request)).Returns(filters);

        _ticketServiceMock.Setup(ts => ts.ListTicketAgentAsync(filters)).ReturnsAsync(ticketData);
        _ticketServiceMock.Setup(ts => ts.CountTicketsByfilterAsync(filters)).ReturnsAsync(2);

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.SUCCESS);
        result.Data.CountTickets.Should().Be(ticketData.Length);
    }

    [Fact]
    public async Task Handle_ValidationError_ThrowsParameterNotProviderException()
    {
        // Arrange
        var request = ListTicketAgentRequestObject();

        var validationResult = new ValidationResult
        {
            Errors =[ new ValidationFailure("PageNumber", _messageManager.GetNotification(FunctionalMessages.NOT_NULL, nameof(ListTicketAgentRequest.PageNumber)))]
        };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(validationResult);

        // Act & Assert

        var result = await _handler.Handle(request, CancellationToken.None);

        result.Code.Should().Be((int)Code.BAD_REQUEST);
    }

    [Fact]
    public async Task Handle_TicketStatusNotFoundException_ReturnsNotFoundResponse()
    {
        // Arrange
        var request = ListTicketAgentRequestObject();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        var filters = ListTicketFiltersDto();

        _mapperMock.Setup(m => m.Map<ListTicketFiltersDto>(request)).Returns(filters);

        _ticketServiceMock.Setup(ts => ts.ListTicketAgentAsync(filters)).ThrowsAsync(new TicketStatusNotFoundException());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.NOT_FOUND);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.TICKET_STATUS_NOT_FOUND));
    }

    [Fact]
    public async Task Handle_ServiceException_ReturnsServiceUnavailableResponse()
    {
        // Arrange
        var request = ListTicketAgentRequestObject();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        var filters = ListTicketFiltersDto();

        _mapperMock.Setup(m => m.Map<ListTicketFiltersDto>(request)).Returns(filters);

        _ticketServiceMock.Setup(ts => ts.ListTicketAgentAsync(filters)).ThrowsAsync(new Exception());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.SERVICE_UNAVAILABLE);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE));
    }


    private ListTicketAgentRequest ListTicketAgentRequestObject()
    {
        return new ListTicketAgentRequest()
        {
            AgentId = null,
            PageNumber = 1,
            PageSize = 10,
            TicketCode = "DS-DIS-1",
            TicketStatusId = null,
            TicketTypeId = null,
            UserIds = null,
        };
    }

    private ListTicketFiltersDto ListTicketFiltersDto()
    {
        return new ListTicketFiltersDto()
        {
            AgentId = null,
            PageNumber = 1,
            PageSize = 10,
            TicketCode = "DS-DIS-1",
            TicketStatusId = null,
            TicketTypeId = null,
            UserIds = null,
        };
    }

    private ListTicketData[] ListTicketData()
    {
        return
        [
        new ListTicketData
        {
            Id = Guid.NewGuid(),
            TicketCode = "DS-DIS-1",
            AgentData = null,
            CreationDate = DateTime.Now,
            UserData = null,
            UserId = Guid.Parse("ee7fc2e2-27f1-4dba-b31f-1e98eaaa4f70"),
            AssignedAgentId = Guid.Parse("18d14490-91c1-4ba6-843c-9b501d187050")

        },
        new ListTicketData
        {
            Id = Guid.NewGuid(),
            TicketCode = "DS-DIS-2",
            AgentData = null,
            CreationDate = DateTime.Now,
            UserData = null,
            UserId = Guid.Parse("ee7fc2e2-27f1-4dba-b31f-1e98eaaa4f70"),
            AssignedAgentId = Guid.Parse("18d14490-91c1-4ba6-843c-9b501d187050")
        }
        ];
    }
}
