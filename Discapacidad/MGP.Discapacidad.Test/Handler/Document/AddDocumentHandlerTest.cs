using AutoMapper;
using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using MGP.Discapacidad.Application.UseCase.V1.Document.AddDocument;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.Domain.interfaces;
using MGP.Discapacidad.Persistance.DTOs.Document;
using Moq;
using Xunit;

namespace MGP.Discapacidad.Test.Handler.Document;
public class AddDocumentHandlerTest
{
    private readonly Mock<IDocumentService> _documentServiceMock;
    private readonly Mock<IValidator<AddDocumentRequestList>> _validatorMock;
    private readonly MessageManager _messageManager;
    private readonly Mock<IMapper> _mapperMock;
    private readonly AddDocumentHandler _handler;

    public AddDocumentHandlerTest()
    {
        _documentServiceMock = new Mock<IDocumentService>();
        _validatorMock = new Mock<IValidator<AddDocumentRequestList>>();
        _mapperMock = new Mock<IMapper>();

        string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
        if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
        _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

        _handler = new AddDocumentHandler(
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
        var request = AddDocumentRequestListObject();
        var documentData = DocumentData();
        var documentResponse = AddDocumentResponse();
        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _mapperMock.Setup(v => v.Map<List<DocumentData>>(request.Documents)).Returns(documentData);
        _mapperMock.Setup(v => v.Map<List<AddDocumentResponse>>(documentData)).Returns(documentResponse);

        _documentServiceMock.Setup(ts => ts.AddDocumentAsync(documentData, request.UserId, request.TicketId)).ReturnsAsync(documentData);

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.CREATED);
        result.Data.Count.Should().Be(2);
    }

    [Fact]
    public async Task Handle_ValidationError_ThrowsParameterNotProviderException()
    {
        // Arrange
        var request =  AddDocumentRequestListObject();
        request.TicketId = Guid.Empty;

        var validationResult = new ValidationResult
        {
            Errors =  [ new ValidationFailure("TicketId", _messageManager.GetNotification(FunctionalMessages.NOT_NULL, nameof(AddDocumentRequestList.TicketId)))]
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
        var request = AddDocumentRequestListObject();
        var documentData = DocumentData();
        var documentResponse = AddDocumentResponse();
        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _mapperMock.Setup(v => v.Map<List<DocumentData>>(request.Documents)).Returns(documentData);
        _mapperMock.Setup(v => v.Map<List<AddDocumentResponse>>(documentData)).Returns(documentResponse);

        _documentServiceMock.Setup(ts => ts.AddDocumentAsync(documentData, request.UserId, request.TicketId)).ThrowsAsync(new TicketNotFoundException());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.NOT_FOUND);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.TICKET_NOT_FOUND));
    }

    [Fact]
    public async Task Handle_DocumentTypeNotFoundException_ReturnsNotFoundResponse()
    {
        // Arrange
        var request = AddDocumentRequestListObject();
        var documentData = DocumentData();
        var documentResponse = AddDocumentResponse();
        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _mapperMock.Setup(v => v.Map<List<DocumentData>>(request.Documents)).Returns(documentData);
        _mapperMock.Setup(v => v.Map<List<AddDocumentResponse>>(documentData)).Returns(documentResponse);

        _documentServiceMock.Setup(ts => ts.AddDocumentAsync(documentData, request.UserId, request.TicketId)).ThrowsAsync(new DocumentTypeNotFoundException());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.NOT_FOUND);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.DOCUMENT_TYPE_NOT_FOUND));
    }

    [Fact]
    public async Task Handle_ServiceException_ReturnsServiceUnavailableResponse()
    {
        // Arrange
        var request = AddDocumentRequestListObject();
        var documentData = DocumentData();
        var documentResponse = AddDocumentResponse();
        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _mapperMock.Setup(v => v.Map<List<DocumentData>>(request.Documents)).Returns(documentData);
        _mapperMock.Setup(v => v.Map<List<AddDocumentResponse>>(documentData)).Returns(documentResponse);

        _documentServiceMock.Setup(ts => ts.AddDocumentAsync(documentData, request.UserId, request.TicketId)).ThrowsAsync(new Exception());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.SERVICE_UNAVAILABLE);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE));
    }

    private AddDocumentRequestList AddDocumentRequestListObject()
    {
        return new AddDocumentRequestList()
        {
            TicketId = Guid.Parse("8e2932d6-2552-4d78-b31f-c1f81dceb4ce"),
            UserId = Guid.Parse("ee7fc2e2-27f1-4dba-b31f-1e98eaaa4f70"),
            Documents = [
                new AddDocumentRequest(){ DocumentImage = "Base64ADSFLNSAF", DocumentTypeId = 1},
                new AddDocumentRequest(){ DocumentImage = "Base64AASDJNSAK", DocumentTypeId = 2}
            ]
        };
    }

    private List<DocumentData> DocumentData()
    {
        return [ new DocumentData() { DocumentImage = "Base64ADSFLNSAF",
                                      TicketId = Guid.Parse("8e2932d6-2552-4d78-b31f-c1f81dceb4ce"),
                                      DocumentTypeId = 1,
                                      DocumentStatusId = 1},

                 new DocumentData() { DocumentImage = "Base64AASDJNSAK",
                                      TicketId = Guid.Parse("8e2932d6-2552-4d78-b31f-c1f81dceb4ce"),
                                      DocumentTypeId = 2,
                                      DocumentStatusId = 1}

               ];
    }

    private List<AddDocumentResponse> AddDocumentResponse()
    {
        return [
            new AddDocumentResponse() { DocumentImage = "URL", DocumentType = null, Id = Guid.Parse("d11aacc0-cf59-446d-84f1-90f019f819d6") },
            new AddDocumentResponse() { DocumentImage = "URLDos", DocumentType = null, Id = Guid.Parse("d15f2c6e-222b-4a04-8bdc-3425451c52f3") }
        ];
    }
}
