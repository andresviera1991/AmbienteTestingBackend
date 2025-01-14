using AutoMapper;
using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using MGP.Discapacidad.Application.UseCase.V1.Document.RemoveTemplate;
using MGP.Discapacidad.Application.UseCase.V1.Document.UpdateTemplate;
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

public class UpdateTemplateHandlerTest
{
    private readonly Mock<IDocumentService> _documentServiceMock;
    private readonly MessageManager _messageManager;
    private readonly Mock<IMapper> _mapperMock;
    private readonly Mock<IValidator<UpdateTemplateRequest>> _validatorMock;
    private readonly UpdateTemplateHandler _handler;

    public UpdateTemplateHandlerTest()
    {
        _documentServiceMock = new Mock<IDocumentService>();
        _validatorMock = new Mock<IValidator<UpdateTemplateRequest>>();
        _mapperMock = new Mock<IMapper>();

        string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
        if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
        _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

        _handler = new UpdateTemplateHandler(
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
        var request = new UpdateTemplateRequest() { Name = "Nuevo Nombre", Id = Guid.Parse("00526b63-5215-490f-9347-d24c00ccd235"),Information = "Completa este formulario",TicketTypeId = TicketTypeEnum.CUD,Status = true };
        var requestData = new UpdateTemplateData() { Name = "Nuevo Nombre", Id = Guid.Parse("00526b63-5215-490f-9347-d24c00ccd235"), Information = "Completa este formulario", TicketTypeId = TicketTypeEnum.CUD, Status = true };
        
        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());
        _mapperMock.Setup(m => m.Map<UpdateTemplateData>(request)).Returns(requestData);

        _documentServiceMock.Setup(ts => ts.UpdateTemplateAsync(requestData));

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
        var request = new UpdateTemplateRequest() { Name = "Nuevo Nombre", Information = "Completa este formulario", TicketTypeId = TicketTypeEnum.CUD, Status = true };

        var validationResult = new ValidationResult
        {
            Errors = [new ValidationFailure("Id", _messageManager.GetNotification(FunctionalMessages.NOT_NULL, nameof(UpdateTemplateRequest.Id)))]
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
        var request = new UpdateTemplateRequest() { Name = "Nuevo Nombre", Id = Guid.Parse("00526b63-5215-490f-9347-d24c00ccd235"), Information = "Completa este formulario", TicketTypeId = TicketTypeEnum.CUD, Status = true };
        var requestData = new UpdateTemplateData() { Name = "Nuevo Nombre", Id = Guid.Parse("00526b63-5215-490f-9347-d24c00ccd235"), Information = "Completa este formulario", TicketTypeId = TicketTypeEnum.CUD, Status = true };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());
        _mapperMock.Setup(m => m.Map<UpdateTemplateData>(request)).Returns(requestData);

        _documentServiceMock.Setup(ts => ts.UpdateTemplateAsync(requestData)).ThrowsAsync(new TemplateNotFoundException());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.NOT_FOUND);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.TEMPLATE_NOT_FOUND));
    }

    [Fact]
    public async Task Handle_TicketTypeNotFoundException_ReturnsNotFoundResponse()
    {
        // Arrange
        var request = new UpdateTemplateRequest() { Name = "Nuevo Nombre", Id = Guid.Parse("00526b63-5215-490f-9347-d24c00ccd235"), Information = "Completa este formulario", TicketTypeId = TicketTypeEnum.CUD, Status = true };
        var requestData = new UpdateTemplateData() { Name = "Nuevo Nombre", Id = Guid.Parse("00526b63-5215-490f-9347-d24c00ccd235"), Information = "Completa este formulario", TicketTypeId = TicketTypeEnum.CUD, Status = true };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());
        _mapperMock.Setup(m => m.Map<UpdateTemplateData>(request)).Returns(requestData);

        _documentServiceMock.Setup(ts => ts.UpdateTemplateAsync(requestData)).ThrowsAsync(new TicketTypeNotFoundException());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.NOT_FOUND);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.TICKET_NOT_FOUND));
    }

    [Fact]
    public async Task Handle_ServiceUnavailableException_ReturnsServiceUnavailableResponse()
    {
        // Arrange
        var request = new UpdateTemplateRequest() { Name = "Nuevo Nombre", Id = Guid.Parse("00526b63-5215-490f-9347-d24c00ccd235"), Information = "Completa este formulario", TicketTypeId = TicketTypeEnum.CUD, Status = true };
        var requestData = new UpdateTemplateData() { Name = "Nuevo Nombre", Id = Guid.Parse("00526b63-5215-490f-9347-d24c00ccd235"), Information = "Completa este formulario", TicketTypeId = TicketTypeEnum.CUD, Status = true };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());
        _mapperMock.Setup(m => m.Map<UpdateTemplateData>(request)).Returns(requestData);

        _documentServiceMock.Setup(ts => ts.UpdateTemplateAsync(requestData)).ThrowsAsync(new Exception());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.SERVICE_UNAVAILABLE);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE));
    }
}
