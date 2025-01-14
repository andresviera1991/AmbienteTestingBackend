using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using MGP.Discapacidad.Application.UseCase.V1.Document.RemoveDocument;
using MGP.Discapacidad.Application.UseCase.V1.Document.RemoveTemplate;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.Domain.interfaces;
using Moq;
using Xunit;
namespace MGP.Discapacidad.Test.Handler.Document;

public class RemoveTemplateHandlerTest
{
    private readonly Mock<IDocumentService> _documentServiceMock;
    private readonly MessageManager _messageManager;
    private readonly Mock<IValidator<RemoveTemplateRequest>> _validatorMock;
    private readonly RemoveTemplateHandler _handler;

    public RemoveTemplateHandlerTest()
    {
        _documentServiceMock = new Mock<IDocumentService>();
        _validatorMock = new Mock<IValidator<RemoveTemplateRequest>>();

        string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
        if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
        _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

        _handler = new RemoveTemplateHandler(
            _documentServiceMock.Object,
            _messageManager,
            _validatorMock.Object
        );
    }

    [Fact]
    public async Task Handle_Success_ReturnsResponseData()
    {
        // Arrange
        var request = new RemoveTemplateRequest() { Id = Guid.Parse("9906387b-8615-4405-a052-e15718ca90ef") };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _documentServiceMock.Setup(ts => ts.RemoveTemplateAsync(request.Id));

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
        var request = new RemoveTemplateRequest() { };

        var validationResult = new ValidationResult
        {
            Errors = [new ValidationFailure("Id", _messageManager.GetNotification(FunctionalMessages.NOT_NULL, nameof(RemoveTemplateRequest.Id)))]
        };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(validationResult);

        // Act & Assert

        var result = await _handler.Handle(request, CancellationToken.None);
        result.Code.Should().Be((int)Code.BAD_REQUEST);
    }

    [Fact]
    public async Task Handle_TemplateNotFoundException_ReturnsNotFoundResponse()
    {
        // Arrange
        var request = new RemoveTemplateRequest() { Id = Guid.Parse("9906387b-8615-4405-a052-e15718ca90ef") };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _documentServiceMock.Setup(ts => ts.RemoveTemplateAsync(request.Id)).ThrowsAsync(new TemplateNotFoundException());

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
        var request = new RemoveTemplateRequest() { Id = Guid.Parse("9906387b-8615-4405-a052-e15718ca90ef") };
        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _documentServiceMock.Setup(ts => ts.RemoveTemplateAsync(request.Id)).ThrowsAsync(new Exception());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.SERVICE_UNAVAILABLE);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE));
    }
}