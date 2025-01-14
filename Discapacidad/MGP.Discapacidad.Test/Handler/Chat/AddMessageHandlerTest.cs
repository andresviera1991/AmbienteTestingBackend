using AutoMapper;
using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using MGP.Discapacidad.Application.UseCase.V1.Chat.AddMessage;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.Domain.Interfaces;
using MGP.Discapacidad.Persistance.DTOs.Chat;
using Moq;
using Xunit;

namespace MGP.Discapacidad.Test.Handler.Chat;

public class AddMessageHandlerTest
{
    private readonly Mock<IChatService> _chatServiceMock;
    private readonly Mock<IValidator<AddMessageRequest>> _validatorMock;
    private readonly MessageManager _messageManager;
    private readonly Mock<IMapper> _mapperMock;
    private readonly AddMessageHandler _handler;

    public AddMessageHandlerTest()
    {
        _chatServiceMock = new Mock<IChatService>();
        _validatorMock = new Mock<IValidator<AddMessageRequest>>();
        _mapperMock = new Mock<IMapper>();

        string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
        if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
        _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

        _handler = new AddMessageHandler(
            _validatorMock.Object,
            _mapperMock.Object,
            _messageManager,
            _chatServiceMock.Object
        );
    }

    [Fact]
    public async Task Handle_Success_ReturnsResponseData()
    {
        // Arrange
        var request = new AddMessageRequest { AgentFullName = "Carlos", Message = "Bienvenido a Marpla Digital", SentAt = DateTime.Now, TicketId = Guid.Parse("64d47c97-59d2-4505-bab0-8aaa6fdc5212") };
        var requestData = new ChatMessageData() { AgentFullName = "Carlos", Message = "Bienvenido a Marpla Digital", SentAt = DateTime.Now, TicketId = Guid.Parse("64d47c97-59d2-4505-bab0-8aaa6fdc5212") };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _mapperMock.Setup(v => v.Map<ChatMessageData>(request)).Returns(requestData);

        _chatServiceMock.Setup(ts => ts.AddMessageAsync(requestData));

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.CREATED);
        result.Data.Success.Should().Be(true);
    }

    [Fact]
    public async Task Handle_ValidationError_ThrowsParameterNotProviderException()
    {
        // Arrange
        var request = new AddMessageRequest { Message = "Bienvenido a Marpla Digital", SentAt = DateTime.Now, TicketId = Guid.Parse("64d47c97-59d2-4505-bab0-8aaa6fdc5212") };

        var validationResult = new ValidationResult
        {
            Errors = [new ValidationFailure("AgentFullName", _messageManager.GetNotification(FunctionalMessages.NOT_NULL, nameof(AddMessageRequest.AgentFullName)))]
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
        var request = new AddMessageRequest { AgentFullName = "Carlos", Message = "Bienvenido a Marpla Digital", SentAt = DateTime.Now, TicketId = Guid.Parse("64d47c97-59d2-4505-bab0-8aaa6fdc5212") };
        var requestData = new ChatMessageData() { AgentFullName = "Carlos", Message = "Bienvenido a Marpla Digital", SentAt = DateTime.Now, TicketId = Guid.Parse("64d47c97-59d2-4505-bab0-8aaa6fdc5212") };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());
        _mapperMock.Setup(v => v.Map<ChatMessageData>(request)).Returns(requestData);

        _chatServiceMock.Setup(ts => ts.AddMessageAsync(requestData)).ThrowsAsync(new TicketNotFoundException());

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
        var request = new AddMessageRequest { AgentFullName = "Carlos", Message = "Bienvenido a Marpla Digital", SentAt = DateTime.Now, TicketId = Guid.Parse("64d47c97-59d2-4505-bab0-8aaa6fdc5212") };
        var requestData = new ChatMessageData() { AgentFullName = "Carlos", Message = "Bienvenido a Marpla Digital", SentAt = DateTime.Now, TicketId = Guid.Parse("64d47c97-59d2-4505-bab0-8aaa6fdc5212") };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());
        _mapperMock.Setup(v => v.Map<ChatMessageData>(request)).Returns(requestData);
        _chatServiceMock.Setup(ts => ts.AddMessageAsync(requestData)).ThrowsAsync(new Exception());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.SERVICE_UNAVAILABLE);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE));
    }

}
