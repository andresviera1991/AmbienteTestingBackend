using AutoMapper;
using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.CUD.Create;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.Domain.interfaces;
using MGP.Discapacidad.Persistance.DTOs.Ticket;
using Moq;
using Xunit;
namespace MGP.Discapacidad.Test.Handler.User.CUD.Create;

public class CreateTicketCudHandlerTest
{
    private readonly Mock<ITicketService> _ticketServiceMock;
    private readonly Mock<IValidator<CreateTicketCudRequest>> _validatorMock;
    private readonly Mock<IMapper> _mapperMock;
    private readonly MessageManager _messageManager;
    private readonly CreateTicketCudHandler _handler;

    public CreateTicketCudHandlerTest()
    {
        _ticketServiceMock = new Mock<ITicketService>();
        _validatorMock = new Mock<IValidator<CreateTicketCudRequest>>();
        _mapperMock = new Mock<IMapper>();
        string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
        if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
        _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

        _handler = new CreateTicketCudHandler(_ticketServiceMock.Object, _validatorMock.Object, _mapperMock.Object, _messageManager);
    }

    [Fact]
    public async Task Handle_Success_ReturnsResponseData()
    {
        // Arrange
        var request = CreateTicketCudRequestObject();
        var requestData = CreateTicketCudData();
        var response = CreateTicketCudResponse();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _mapperMock.Setup(m => m.Map<CreateTicketCudData>(request)).Returns(requestData);
        _mapperMock.Setup(m => m.Map<CreateTicketCudResponse>(requestData)).Returns(response);

        _ticketServiceMock.Setup(ts => ts.CreateTicketCudAsync(requestData)).ReturnsAsync(requestData);

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.CREATED);
        result.Data.TicketCode.Should().Be("TICKET123");
    }

    [Fact]
    public async Task Handle_ValidationError_ThrowsParameterNotProviderException()
    {
        // Arrange
        var request = CreateTicketCudRequestObject();
        request.Email = "";

        var validationResult = new ValidationResult
        {
            Errors = [new ValidationFailure("Email", _messageManager.GetNotification(FunctionalMessages.NOT_NULL, nameof(CreateTicketCudRequest.Email)))]
        };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(validationResult);

        // Act & Assert

        var result = await _handler.Handle(request, CancellationToken.None);
        result.Code.Should().Be((int)Code.BAD_REQUEST);
    }

    [Fact]
    public async Task Handle_EmailException_ReturnsCreatedResponse()
    {
        // Arrange
        var request = CreateTicketCudRequestObject();
        var requestData = CreateTicketCudData();
        var response = CreateTicketCudResponse();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _mapperMock.Setup(m => m.Map<CreateTicketCudData>(request)).Returns(requestData);
        _mapperMock.Setup(m => m.Map<CreateTicketCudResponse>(requestData)).Returns(response);

        _ticketServiceMock.Setup(ts => ts.CreateTicketCudAsync(requestData)).ThrowsAsync(new EmailException());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.CREATED);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.ERROR_SEND_EMAIL));
    }

    [Fact]
    public async Task Handle_TicketAlreadyOpenException_ReturnsConflictResponse()
    {
        // Arrange
        var request = CreateTicketCudRequestObject();
        var requestData = CreateTicketCudData();
        var response = CreateTicketCudResponse();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _mapperMock.Setup(m => m.Map<CreateTicketCudData>(request)).Returns(requestData);
        _mapperMock.Setup(m => m.Map<CreateTicketCudResponse>(requestData)).Returns(response);

        _ticketServiceMock.Setup(ts => ts.CreateTicketCudAsync(requestData)).ThrowsAsync(new TicketAlreadyOpenException());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.CONFLICT);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.TICKET_ALREADY_OPEN));
    }

    [Fact]
    public async Task Handle_DocumentUploadException_ReturnsConflictResponse()
    {
        // Arrange
        var request = CreateTicketCudRequestObject();
        var requestData = CreateTicketCudData();
        var response = CreateTicketCudResponse();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _mapperMock.Setup(m => m.Map<CreateTicketCudData>(request)).Returns(requestData);
        _mapperMock.Setup(m => m.Map<CreateTicketCudResponse>(requestData)).Returns(response);

        _ticketServiceMock.Setup(ts => ts.CreateTicketCudAsync(requestData)).ThrowsAsync(new DocumentUploadException());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.BAD_REQUEST);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.UPLOAD_DOCUMENT_ERROR));
    }

    [Fact]
    public async Task Handle_DocumentTypeNotFoundException_ReturnsNotFoundResponse()
    {
        // Arrange
        var request = CreateTicketCudRequestObject();
        var requestData = CreateTicketCudData();
        var response = CreateTicketCudResponse();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _mapperMock.Setup(m => m.Map<CreateTicketCudData>(request)).Returns(requestData);
        _mapperMock.Setup(m => m.Map<CreateTicketCudResponse>(requestData)).Returns(response);

        _ticketServiceMock.Setup(ts => ts.CreateTicketCudAsync(requestData)).ThrowsAsync(new DocumentTypeNotFoundException());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.NOT_FOUND);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.DOCUMENT_NOT_FOUND));
    }

    [Fact]
    public async Task Handle_ServiceUnavailableException_ReturnsServiceUnavailableResponse()
    {
        // Arrange
        var request = CreateTicketCudRequestObject();
        var requestData = CreateTicketCudData();
        var response = CreateTicketCudResponse();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _mapperMock.Setup(m => m.Map<CreateTicketCudData>(request)).Returns(requestData);
        _mapperMock.Setup(m => m.Map<CreateTicketCudResponse>(requestData)).Returns(response);

        _ticketServiceMock.Setup(ts => ts.CreateTicketCudAsync(requestData)).ThrowsAsync(new Exception());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.SERVICE_UNAVAILABLE);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE));
    }

    private CreateTicketCudRequest CreateTicketCudRequestObject()
    {
        return new CreateTicketCudRequest
        {
            Email = "test@example.com",
            TicketCode = "TICKET123",
            TicketStatusId = 1,
            Certificate = true,
            ExpiredCertificate = false,
            CertificateExpansionOptionsId = 1,
            LostCertificate = false,
            HealthInsurance = true,
            PaySlip = true,
            SignatureOptionId = 1,
            DocumentComplete = true,
            MedicalCommitteId = Guid.NewGuid(),
            Documents = []
        };
    }

    private static CreateTicketCudData CreateTicketCudData()
    {
        return new CreateTicketCudData
        {
            Email = "test@example.com",
            TicketCode = "TICKET123",
            TicketStatusId = 1,
            Certificate = true,
            ExpiredCertificate = false,
            CertificateExpansionOptionsId = 1,
            LostCertificate = false,
            HealthInsurance = true,
            PaySlip = true,
            SignatureOptionId = 1,
            DocumentComplete = true,
            Documents = []
        };
    }

    private static CreateTicketCudResponse CreateTicketCudResponse()
    {
        return new CreateTicketCudResponse() { TicketCode = "TICKET123", Id = Guid.Parse("64d47c97-59d2-4505-bab0-8aaa6fdc5212") };
    }
}