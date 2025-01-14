using FluentValidation;
using FluentValidation.Results;
using FluentAssertions;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.Domain.interfaces;
using MGP.Discapacidad.Persistance.DTOs.Ticket;
using Moq;
using Xunit;
using AutoMapper;
using MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.PARKING.Get;
namespace MGP.Discapacidad.Test.Handler.Agent.PARKING.Get;

public class GetTicketParkingAgentHandlerTest
{
    private readonly Mock<ITicketService> _ticketServiceMock;
    private readonly Mock<IValidator<GetTicketParkingAgentRequest>> _validatorMock;
    private readonly MessageManager _messageManager;
    private readonly Mock<IMapper> _mapperMock;
    private readonly GetTicketParkingAgentHandler _handler;

    public GetTicketParkingAgentHandlerTest()
    {
        _ticketServiceMock = new Mock<ITicketService>();
        _validatorMock = new Mock<IValidator<GetTicketParkingAgentRequest>>();
        _mapperMock = new Mock<IMapper>();

        string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
        if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
        _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

        _handler = new GetTicketParkingAgentHandler(
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
        var request = new GetTicketParkingAgentRequest { TicketId = Guid.Parse("96949bb8-8c14-466d-b34f-3c9d491dd96a"), TicketCode = "DS-DIS-1" };
        var ticketData = GetTicketParkingData();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _ticketServiceMock.Setup(ts => ts.GetTicketParkingAgentAsync(request.TicketId, request.TicketCode)).ReturnsAsync(ticketData);

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.SUCCESS);
    }

    [Fact]
    public async Task Handle_ValidationError_ThrowsParameterNotProviderException()
    {
        // Arrange
        var request = new GetTicketParkingAgentRequest { };

        var validationResult = new ValidationResult
        {
            Errors =
                [
                    new ValidationFailure("TicketId", _messageManager.GetNotification(FunctionalMessages.NOT_NULL, nameof(GetTicketParkingAgentRequest.TicketId))),
                    new ValidationFailure("TicketCode", _messageManager.GetNotification(FunctionalMessages.NOT_NULL, nameof(GetTicketParkingAgentRequest.TicketCode)))
                ]
        };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(validationResult);

        // Act & Assert

        var result = await _handler.Handle(request, CancellationToken.None);
        result.Code.Should().Be((int)Code.BAD_REQUEST);
    }

    [Fact]
    public async Task Handle_NotFoundException_ReturnsNotFoundResponse()
    {
        // Arrange
        var request = new GetTicketParkingAgentRequest { TicketId = Guid.Parse("96949bb8-8c14-466d-b34f-3c9d491dd96a"), TicketCode = "DS-DIS-1" };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _ticketServiceMock.Setup(ts => ts.GetTicketParkingAgentAsync(request.TicketId, request.TicketCode)).ThrowsAsync(new TicketNotFoundException());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.NOT_FOUND);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.TICKET_NOT_FOUND));
    }

    [Fact]
    public async Task Handle_ServiceException_ReturnsServiceUnavailableResponse()
    {
        // Arrange
        var request = new GetTicketParkingAgentRequest { TicketId = Guid.Parse("96949bb8-8c14-466d-b34f-3c9d491dd96a"), TicketCode = "DS-DIS-1" };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _ticketServiceMock.Setup(ts => ts.GetTicketParkingAgentAsync(request.TicketId, request.TicketCode)).ThrowsAsync(new Exception());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.SERVICE_UNAVAILABLE);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE));
    }

    private GetTicketParkingData GetTicketParkingData()
    {
        return new GetTicketParkingData()
        {
            Ticket = new TicketData()
            {
                AgentData = null,
                UserData = null,
                AssignedAgentId = Guid.Parse("18d14490-91c1-4ba6-843c-9b501d187051"),
                CreationDate = DateTime.Now,
                Documents = null,
                Id = Guid.Parse("96949bb8-8c14-466d-b34f-3c9d491dd96a"),
                GDECode = null,
                TicketCode = "DS-DIS-1",
                TicketStatus = null,
                TicketType = null,
                UserId = Guid.Parse("3dd3d868-541d-4275-9146-3b4449ffaa8c")
            }
        };
    }
}
