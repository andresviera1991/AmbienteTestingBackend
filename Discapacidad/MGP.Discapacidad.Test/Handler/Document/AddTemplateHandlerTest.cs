using AutoMapper;
using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using MGP.Discapacidad.Application.UseCase.V1.Document.AddTemplate;
using MGP.Discapacidad.CrossCutting.Enum;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.Domain.interfaces;
using MGP.Discapacidad.Persistance.DTOs.Document;
using Moq;
using Xunit;

namespace MGP.Discapacidad.Test.Handler.Document;

public class AddTemplateHandlerTest
{
    private readonly Mock<IDocumentService> _documentServiceMock;
    private readonly Mock<IValidator<AddTemplateRequest>> _validatorMock;
    private readonly MessageManager _messageManager;
    private readonly Mock<IMapper> _mapperMock;
    private readonly AddTemplateHandler _handler;

    public AddTemplateHandlerTest()
    {
        _documentServiceMock = new Mock<IDocumentService>();
        _validatorMock = new Mock<IValidator<AddTemplateRequest>>();
        _mapperMock = new Mock<IMapper>();

        string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
        if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
        _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

        _handler = new AddTemplateHandler(
            _documentServiceMock.Object,
            _mapperMock.Object,
            _messageManager,
            _validatorMock.Object
        );
    }

    [Fact]
    public async Task Handle_Success_ReturnsResponseData()
    {
        // Arrange
        var request = AddTemplateRequestObject();
        var requestData = AddTemplateDataObject();
        var templateId = Guid.NewGuid();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());
        _mapperMock.Setup(v => v.Map<AddTemplateData>(request)).Returns(requestData);
        _documentServiceMock.Setup(ts => ts.AddTemplateAsync(requestData)).ReturnsAsync(templateId);

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.CREATED);
        result.Data.Id.Should().Be(templateId);
    }

    [Fact]
    public async Task Handle_ValidationError_ThrowsParameterNotProviderException()
    {
        // Arrange
        var request = AddTemplateRequestObject();
        request.TicketTypeId = 0;

        var validationResult = new ValidationResult
        {
            Errors = [new ValidationFailure("TicketTypeId", _messageManager.GetNotification(FunctionalMessages.NOT_NULL, nameof(AddTemplateRequest.TicketTypeId)))]
        };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(validationResult);

        // Act & Assert

        var result = await _handler.Handle(request, CancellationToken.None);
        result.Code.Should().Be((int)Code.BAD_REQUEST);
    }

    [Fact]
    public async Task Handle_TicketNotFoundNotFoundException_ReturnsNotFoundResponse()
    {
        // Arrange
        var request = AddTemplateRequestObject();
        var requestData = AddTemplateDataObject();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());
        _mapperMock.Setup(v => v.Map<AddTemplateData>(request)).Returns(requestData);
        _documentServiceMock.Setup(ts => ts.AddTemplateAsync(requestData)).ThrowsAsync(new TemplateDocumentAlreadyExistsException());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.CONFLICT);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.TEMPLATE_ALREADY_EXISTS));
    }

    [Fact]
    public async Task Handle_TicketTypeNotFoundException_ReturnsNotFoundResponse()
    {
        // Arrange
        var request = AddTemplateRequestObject();
        var requestData = AddTemplateDataObject();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());
        _mapperMock.Setup(v => v.Map<AddTemplateData>(request)).Returns(requestData);
        _documentServiceMock.Setup(ts => ts.AddTemplateAsync(requestData)).ThrowsAsync(new TicketTypeNotFoundException());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.NOT_FOUND);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.TICKET_TYPE_NOT_FOUND));
    }

    [Fact]
    public async Task Handle_ServiceException_ReturnsServiceUnavailableResponse()
    {
        // Arrange
        var request = AddTemplateRequestObject();
        var requestData = AddTemplateDataObject();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());
        _mapperMock.Setup(v => v.Map<AddTemplateData>(request)).Returns(requestData);
        _documentServiceMock.Setup(ts => ts.AddTemplateAsync(requestData)).ThrowsAsync(new Exception());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.SERVICE_UNAVAILABLE);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE));
    }

    private static AddTemplateRequest AddTemplateRequestObject()
    {
        return new AddTemplateRequest() { DocumentPDF = "BASE64STRING", Information = "Por favor, completar y reenviar", Name = "Patologías", TicketTypeId = TicketTypeEnum.CUD };
    }

    private static AddTemplateData AddTemplateDataObject()
    {
        return new AddTemplateData() { DocumentPDF = "BASE64STRING", Information = "Por favor, completar y reenviar", Name = "Patologías", TicketTypeId = TicketTypeEnum.CUD };
    }
}
