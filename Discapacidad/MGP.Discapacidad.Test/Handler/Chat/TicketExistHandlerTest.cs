using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using MGP.Discapacidad.Application.UseCase.V1.Chat.VerifyTicket;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.Domain.interfaces;
using Moq;
using Xunit;
namespace MGP.Discapacidad.Test.Handler.Chat;

public class TicketExistHandlerTest
{
    private readonly Mock<ITicketService> _ticketServiceMock;
    private readonly Mock<IValidator<TicketExistRequest>> _validatorMock;
    private readonly MessageManager _messageManager;
    private readonly TicketExistHandler _handler;

    public TicketExistHandlerTest()
    {
        _ticketServiceMock = new Mock<ITicketService>();
        _validatorMock = new Mock<IValidator<TicketExistRequest>>();

        string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
        if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
        _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

        _handler = new TicketExistHandler(
             _ticketServiceMock.Object,
            _validatorMock.Object
        );
    }

    [Fact]
    public async Task Handle_Success_ReturnsResponseData()
    {
        // Arrange
        var request = new TicketExistRequest { TicketId = Guid.Parse("64d47c97-59d2-4505-bab0-8aaa6fdc5212") };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _ticketServiceMock.Setup(ts => ts.TicketExitsAsync(request.TicketId)).ReturnsAsync(true);

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().Be(true);
    }

    [Fact]
    public async Task Handle_ValidationError_ThrowsParameterNotProviderException()
    {
        // Arrange
        var request = new TicketExistRequest { };

        var validationResult = new ValidationResult
        {
            Errors = [new ValidationFailure("TicketId", _messageManager.GetNotification(FunctionalMessages.NOT_NULL, nameof(TicketExistRequest.TicketId)))]
        };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(validationResult);

        // Act & Assert

        var result = await _handler.Handle(request, CancellationToken.None);

        result.Should().Be(false);
    }

    [Fact]
    public async Task Handle_ServiceException_ReturnsServiceUnavailableResponse()
    {
        // Arrange
        var request = new TicketExistRequest { TicketId = Guid.Parse("64d47c97-59d2-4505-bab0-8aaa6fdc5212") };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _ticketServiceMock.Setup(ts => ts.TicketExitsAsync(request.TicketId)).ThrowsAsync(new Exception());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().Be(false);
    }

}
