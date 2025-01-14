using AutoMapper;
using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.PARKING.Update;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.Domain.interfaces;
using MGP.Discapacidad.Persistance.DTOs.Ticket;
using Moq;
using Xunit;

namespace MGP.Discapacidad.Test.Handler.Agent.PARKING.Update;

public class UpdateTicketParkingAgentHandlerTest
{
    private readonly Mock<ITicketService> _ticketServiceMock;
    private readonly Mock<IValidator<UpdateTicketParkingRequest>> _validatorMock;
    private readonly MessageManager _messageManager;
    private readonly Mock<IMapper> _mapperMock;
    private readonly UpdateTicketParkingHandler _handler;

    public UpdateTicketParkingAgentHandlerTest()
    {
        _ticketServiceMock = new Mock<ITicketService>();
        _validatorMock = new Mock<IValidator<UpdateTicketParkingRequest>>();
        _mapperMock = new Mock<IMapper>();

        string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
        if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
        _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

        _handler = new UpdateTicketParkingHandler(
            _ticketServiceMock.Object,
            _validatorMock.Object,
            _messageManager,
            _mapperMock.Object
        );
    }

    [Fact]
    public async Task Handle_Should_Update_Ticket_When_Validation_Is_Successful()
    {
        // Arrange
        var request = UpdateTicketParkingRequestObject();
        var updatedData = UpdateTicketParkingData();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

        _mapperMock.Setup(m => m.Map<UpdateTicketParkingData>(request)).Returns(updatedData);

        _ticketServiceMock.Setup(ts => ts.UpdateTicketParkingAsync(updatedData)).Returns(Task.CompletedTask);

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.SUCCESS);
        result.Data.Success.Should().BeTrue();
    }

    [Fact]
    public async Task Handle_Should_Throw_ParameterNotProviderException_When_Validation_Fails()
    {
        // Arrange
        var request = UpdateTicketParkingRequestObject();

        var validationResult = new ValidationResult
        {
            Errors = [new ValidationFailure("TicketId", _messageManager.GetNotification(FunctionalMessages.NOT_NULL, nameof(UpdateTicketParkingRequest.TicketId)))]
        };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(validationResult);

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        result.Code.Should().Be((int)Code.BAD_REQUEST);
    }

    [Fact]
    public async Task Handle_Should_Return_NotFound_When_Ticket_Is_Not_Found()
    {
        // Arrange
        var request = UpdateTicketParkingRequestObject();
        var requestData = UpdateTicketParkingData();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _mapperMock.Setup(m => m.Map<UpdateTicketParkingData>(request)).Returns(requestData);

        _ticketServiceMock.Setup(s => s.UpdateTicketParkingAsync(requestData)).Throws(new TicketNotFoundException());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.NOT_FOUND);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.TICKET_NOT_FOUND));
    }

    [Fact]
    public async Task Handle_Should_Return_TicketStatusNotFoundException_When_TicketStatusIsNotValid()
    {
        // Arrange
        var request = UpdateTicketParkingRequestObject();
        var requestData = UpdateTicketParkingData();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _mapperMock.Setup(m => m.Map<UpdateTicketParkingData>(request)).Returns(requestData);

        _ticketServiceMock.Setup(s => s.UpdateTicketParkingAsync(requestData)).Throws(new TicketStatusNotFoundException());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.NOT_FOUND);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.TICKET_STATUS_NOT_FOUND));
    }

    [Fact]
    public async Task Handle_Should_Return_InvalidDate_When_MedicalCommitteDateIsInvalid()
    {
        // Arrange
        var request = UpdateTicketParkingRequestObject();
        var requestData = UpdateTicketParkingData();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _mapperMock.Setup(m => m.Map<UpdateTicketParkingData>(request)).Returns(requestData);

        _ticketServiceMock.Setup(s => s.UpdateTicketParkingAsync(requestData)).Throws(new InvalidMedicalCommitteDateException());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.BAD_REQUEST);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.INVALID_DATE));
    }

    [Fact]
    public async Task Handle_Should_Return_ServiceUnavailable_When_ServiceUnavailable()
    {
        // Arrange
        var request = UpdateTicketParkingRequestObject();
        var requestData = UpdateTicketParkingData();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _mapperMock.Setup(m => m.Map<UpdateTicketParkingData>(request)).Returns(requestData);

        _ticketServiceMock.Setup(s => s.UpdateTicketParkingAsync(requestData)).Throws(new Exception());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.SERVICE_UNAVAILABLE);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE));
    }

    private UpdateTicketParkingRequest UpdateTicketParkingRequestObject()
    {
        return new UpdateTicketParkingRequest()
        {
            TicketId = Guid.Parse("96949bb8-8c14-466d-b34f-3c9d491dd96a"),
            TicketStatusId = 3,
            UpdateDocumentStatus = null,
            UserEmail = ""
        };
    }

    private UpdateTicketParkingData UpdateTicketParkingData()
    {
        return new UpdateTicketParkingData()
        {
            TicketId = Guid.Parse("96949bb8-8c14-466d-b34f-3c9d491dd96a"),
            TicketStatusId = 3,
            UpdateDocumentStatus = null,
            UserEmail = ""
        };
    }
}
