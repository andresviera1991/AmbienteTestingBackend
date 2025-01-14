using AutoMapper;
using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using MGP.Discapacidad.Application.UseCase.V1.Document.AddDocument;
using MGP.Discapacidad.Application.UseCase.V1.Supervisor.ReassignTicket;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.Domain.interfaces;
using Moq;
using Xunit;

namespace MGP.Discapacidad.Test.Handler.Supervisor;

public class ReassignTicketHandlerTest
{
    private readonly Mock<ITicketService> _ticketServiceMock;
    private readonly Mock<IValidator<ReassignTicketRequest>> _validatorMock;
    private readonly MessageManager _messageManager;
    private readonly ReassignTicketHandler _handler;

    public ReassignTicketHandlerTest()
    {
        _ticketServiceMock = new Mock<ITicketService>();
        _validatorMock = new Mock<IValidator<ReassignTicketRequest>>();

        string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
        if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
        _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

        _handler = new ReassignTicketHandler(
            _ticketServiceMock.Object,
            _validatorMock.Object,
            _messageManager
        );
    }

    [Fact]
    public async Task Handle_Success_ReturnsResponseData()
    {
        // Arrange
        var request = new ReassignTicketRequest(){ AgentId = Guid.Parse("18d14490-91c1-4ba6-843c-9b501d187050"), SupervisorId = Guid.Parse("18d14490-91c1-4ba6-843c-9b501d187049"), TicketId = Guid.Parse("8e2932d6-2552-4d78-b31f-c1f81dceb4ce")};

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _ticketServiceMock.Setup(ts => ts.ReassignTicketAsync(request.TicketId, request.AgentId, request.SupervisorId));

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.SUCCESS);
        result.Data.Success.Should().BeTrue();
    }

    [Fact]
    public async Task Handle_ValidationError_ThrowsParameterNotProviderException()
    {
        // Arrange
        var request = new ReassignTicketRequest() { SupervisorId = Guid.Parse("18d14490-91c1-4ba6-843c-9b501d187049"), TicketId = Guid.Parse("8e2932d6-2552-4d78-b31f-c1f81dceb4ce") };

        var validationResult = new ValidationResult
        {
            Errors = [new ValidationFailure("AgentId", _messageManager.GetNotification(FunctionalMessages.NOT_NULL, nameof(ReassignTicketRequest.AgentId)))]
        };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(validationResult);

        // Act & Assert

        var result = await _handler.Handle(request, CancellationToken.None);
        result.Code.Should().Be((int)Code.BAD_REQUEST);
    }

    [Fact]
    public async Task Handle_TicketNotFoundException_ReturnsNotFoundResponse()
    {
        // Arrange
        var request = new ReassignTicketRequest() { AgentId = Guid.Parse("18d14490-91c1-4ba6-843c-9b501d187050"), SupervisorId = Guid.Parse("18d14490-91c1-4ba6-843c-9b501d187049"), TicketId = Guid.Parse("8e2932d6-2552-4d78-b31f-c1f81dceb4ce") };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _ticketServiceMock.Setup(ts => ts.ReassignTicketAsync(request.TicketId, request.AgentId, request.SupervisorId)).ThrowsAsync(new TicketNotFoundException());

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
        var request = new ReassignTicketRequest() { AgentId = Guid.Parse("18d14490-91c1-4ba6-843c-9b501d187050"), SupervisorId = Guid.Parse("18d14490-91c1-4ba6-843c-9b501d187049"), TicketId = Guid.Parse("8e2932d6-2552-4d78-b31f-c1f81dceb4ce") };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _ticketServiceMock.Setup(ts => ts.ReassignTicketAsync(request.TicketId, request.AgentId, request.SupervisorId)).ThrowsAsync(new Exception());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.SERVICE_UNAVAILABLE);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE));
    }
}
