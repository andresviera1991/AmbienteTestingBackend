using AutoMapper;
using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.CUD.Create;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.PARKING.Create;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.Domain.interfaces;
using MGP.Discapacidad.Persistance.DTOs.Ticket;
using Moq;
using Xunit;
namespace MGP.Discapacidad.Test.Handler.User.PARKING.Create;

public class CreateTicketParkingHandlerTest
{
    private readonly Mock<ITicketService> _ticketServiceMock;
    private readonly Mock<IValidator<CreateTicketParkingRequest>> _validatorMock;
    private readonly Mock<IMapper> _mapperMock;
    private readonly MessageManager _messageManager;
    private readonly CreateTicketParkingHandler _handler;

    public CreateTicketParkingHandlerTest()
    {
        _ticketServiceMock = new Mock<ITicketService>();
        _validatorMock = new Mock<IValidator<CreateTicketParkingRequest>>();
        _mapperMock = new Mock<IMapper>();
        string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
        if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
        _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

        _handler = new CreateTicketParkingHandler(_ticketServiceMock.Object, _mapperMock.Object, _validatorMock.Object, _messageManager);
    }

    [Fact]
    public async Task Handle_Success_ReturnsResponseData()
    {
        // Arrange
        var request = CreateTicketParkingRequestObject();
        var requestData = CreateTicketParkingData();
        var response = CreateTicketParkingResponse();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _mapperMock.Setup(m => m.Map<CreateTicketParkingData>(request)).Returns(requestData);
        _mapperMock.Setup(m => m.Map<CreateTicketParkingResponse>(requestData)).Returns(response);

        _ticketServiceMock.Setup(ts => ts.CreateTicketParkingAsync(requestData)).ReturnsAsync(requestData);

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
        var request = CreateTicketParkingRequestObject();
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
        var request = CreateTicketParkingRequestObject();
        var requestData = CreateTicketParkingData();
        var response = CreateTicketParkingResponse();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _mapperMock.Setup(m => m.Map<CreateTicketParkingData>(request)).Returns(requestData);
        _mapperMock.Setup(m => m.Map<CreateTicketParkingResponse>(requestData)).Returns(response);

        _ticketServiceMock.Setup(ts => ts.CreateTicketParkingAsync(requestData)).ThrowsAsync(new EmailException());

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
        var request = CreateTicketParkingRequestObject();
        var requestData = CreateTicketParkingData();
        var response = CreateTicketParkingResponse();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _mapperMock.Setup(m => m.Map<CreateTicketParkingData>(request)).Returns(requestData);
        _mapperMock.Setup(m => m.Map<CreateTicketParkingResponse>(requestData)).Returns(response);

        _ticketServiceMock.Setup(ts => ts.CreateTicketParkingAsync(requestData)).ThrowsAsync(new TicketAlreadyOpenException());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.CONFLICT);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.TEMPLATE_ALREADY_EXISTS));
    }

    [Fact]
    public async Task Handle_DocumentUploadException_ReturnsConflictResponse()
    {
        // Arrange
        var request = CreateTicketParkingRequestObject();
        var requestData = CreateTicketParkingData();
        var response = CreateTicketParkingResponse();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _mapperMock.Setup(m => m.Map<CreateTicketParkingData>(request)).Returns(requestData);
        _mapperMock.Setup(m => m.Map<CreateTicketParkingResponse>(requestData)).Returns(response);

        _ticketServiceMock.Setup(ts => ts.CreateTicketParkingAsync(requestData)).ThrowsAsync(new DocumentUploadException());

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
        var request = CreateTicketParkingRequestObject();
        var requestData = CreateTicketParkingData();
        var response = CreateTicketParkingResponse();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _mapperMock.Setup(m => m.Map<CreateTicketParkingData>(request)).Returns(requestData);
        _mapperMock.Setup(m => m.Map<CreateTicketParkingResponse>(requestData)).Returns(response);

        _ticketServiceMock.Setup(ts => ts.CreateTicketParkingAsync(requestData)).ThrowsAsync(new DocumentTypeNotFoundException());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.NOT_FOUND);
        result.ErrorMessage.Message.Should().BeEquivalentTo(_messageManager.GetNotification(FunctionalMessages.DOCUMENT_NOT_FOUND));
    }

    [Fact]
    public async Task Handle_ServiceUnavailableException_ReturnsServiceUnavailableResponse()
    {
        // Arrange
        var request = CreateTicketParkingRequestObject();
        var requestData = CreateTicketParkingData();
        var response = CreateTicketParkingResponse();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _mapperMock.Setup(m => m.Map<CreateTicketParkingData>(request)).Returns(requestData);
        _mapperMock.Setup(m => m.Map<CreateTicketParkingResponse>(requestData)).Returns(response);

        _ticketServiceMock.Setup(ts => ts.CreateTicketParkingAsync(requestData)).ThrowsAsync(new Exception());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.SERVICE_UNAVAILABLE);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE));
    }

    private static CreateTicketParkingRequest CreateTicketParkingRequestObject()
    {
        return new CreateTicketParkingRequest
        {
            Email = "test@example.com",
            Documents = []
        };
    }
    private static CreateTicketParkingData CreateTicketParkingData()
    {
        return new CreateTicketParkingData
        {
            Email = "test@example.com",
            TicketCode = "TICKET123",
            TicketStatusId = 1,
            Documents = []
        };
    }
    private static CreateTicketParkingResponse CreateTicketParkingResponse()
    {
        return new CreateTicketParkingResponse() { TicketCode = "TICKET123", Id = Guid.Parse("64d47c97-59d2-4505-bab0-8aaa6fdc5212") };
    }
}