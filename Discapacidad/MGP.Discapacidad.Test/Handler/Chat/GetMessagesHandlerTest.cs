using AutoMapper;
using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using MGP.Discapacidad.Application.UseCase.V1.Chat.AddMessage;
using MGP.Discapacidad.Application.UseCase.V1.Chat.GetMessages;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.Domain.Interfaces;
using MGP.Discapacidad.Persistance.DTOs.Chat;
using Moq;
using Xunit;

namespace MGP.Discapacidad.Test.Handler.Chat;

public class GetMessagesHandlerTest
{
    private readonly Mock<IChatService> _chatServiceMock;
    private readonly Mock<IValidator<GetMessagesRequest>> _validatorMock;
    private readonly MessageManager _messageManager;
    private readonly GetMessagesHandler _handler;

    public GetMessagesHandlerTest()
    {
        _chatServiceMock = new Mock<IChatService>();
        _validatorMock = new Mock<IValidator<GetMessagesRequest>>();

        string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
        if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
        _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

        _handler = new GetMessagesHandler(
            _validatorMock.Object,
            _messageManager,
            _chatServiceMock.Object
        );
    }

    [Fact]
    public async Task Handle_Success_ReturnsResponseData()
    {
        // Arrange
        var request = new GetMessagesRequest { TicketId = Guid.Parse("64d47c97-59d2-4505-bab0-8aaa6fdc5212") };
        var responseData = ListMessageData();
        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _chatServiceMock.Setup(ts => ts.GetMessagesAsync(request.TicketId)).ReturnsAsync(responseData);

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.SUCCESS);
        result.Data.GetMessageData.Count.Should().Be(2);
    }

    [Fact]
    public async Task Handle_ValidationError_ThrowsParameterNotProviderException()
    {
        // Arrange
        var request = new GetMessagesRequest {  };

        var validationResult = new ValidationResult
        {
            Errors = [new ValidationFailure("TicketId", _messageManager.GetNotification(FunctionalMessages.NOT_NULL, nameof(GetMessagesRequest.TicketId)))]
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
        var request = new GetMessagesRequest { TicketId = Guid.Parse("64d47c97-59d2-4505-bab0-8aaa6fdc5212") };
        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _chatServiceMock.Setup(ts => ts.GetMessagesAsync(request.TicketId)).ThrowsAsync(new TicketNotFoundException());

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
        var request = new GetMessagesRequest { TicketId = Guid.Parse("64d47c97-59d2-4505-bab0-8aaa6fdc5212") };
        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _chatServiceMock.Setup(ts => ts.GetMessagesAsync(request.TicketId)).ThrowsAsync(new Exception());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.SERVICE_UNAVAILABLE);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE));
    }

    private List<GetMessageData> ListMessageData()
    {
        return [
            new GetMessageData(){ AgentFullName = "Carlos", Message = "Bienvenido a Marpla Digital", SentAt = DateTime.Now.ToString()},
            new GetMessageData(){ AgentFullName = "Carlos", Message = "¿En qué puedo ayudarte?", SentAt = DateTime.Now.ToString()},
        ];
    }
}
