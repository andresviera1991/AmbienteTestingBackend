using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.Update;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.Domain.interfaces;
using Moq;
using Xunit;
namespace MGP.Discapacidad.Test.Handler.User.CANCEL;

public class CancelTicketHandlerTest
{
    private readonly Mock<ITicketService> _ticketServiceMock;
    private readonly Mock<IValidator<CancelTicketRequest>> _validatorMock;
    private readonly MessageManager _messageManager;
    private readonly CancelTicketHandler _handler;

    public CancelTicketHandlerTest()
    {
        _ticketServiceMock = new Mock<ITicketService>();
        _validatorMock = new Mock<IValidator<CancelTicketRequest>>();
        string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");

        if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
        _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

        _handler = new CancelTicketHandler(_ticketServiceMock.Object, _validatorMock.Object, _messageManager);
    }

    [Fact]
    public async Task Handle_ShouldReturnSuccess_WhenValidationSucceeds()
    {
        //Arrange
        var request = new CancelTicketRequest() { TicketId = Guid.Parse("3dd3d868-541d-4275-9146-3b4449ffaa8c"), UserId = Guid.Parse("ee7fc2e2-27f1-4dba-b31f-1e98eaaa4f70") };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());


        _ticketServiceMock.Setup(s => s.CancelTicketAsync(request.UserId, request.TicketId));

        //Act and Assert
        var result = await _handler.Handle(request, CancellationToken.None);

        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.SUCCESS);
    }

    [Fact]
    public async Task Handle_ShouldReturnBadRequest_WhenParametersAreMissing()
    {
        //Arrange
        var request = new CancelTicketRequest() { UserId = Guid.Parse("ee7fc2e2-27f1-4dba-b31f-1e98eaaa4f70") };

        var validationResult = new FluentValidation.Results.ValidationResult
        {
            Errors = { new ValidationFailure("TicketId", "Ticket Id cannot be null.") }
        };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(validationResult);

        //Act and Assert
        var result = await _handler.Handle(request, CancellationToken.None);

        result.Code.Should().Be((int)Code.BAD_REQUEST);
    }

    [Fact]
    public async Task Handle_NotFoundException_WhenTicketNotFound()
    {
        //Arrange
        var request = new CancelTicketRequest() { TicketId = Guid.Parse("3dd3d868-541d-4275-9146-3b4449ffaa8c"), UserId = Guid.Parse("ee7fc2e2-27f1-4dba-b31f-1e98eaaa4f70") };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());


        _ticketServiceMock.Setup(s => s.CancelTicketAsync(request.UserId, request.TicketId)).ThrowsAsync(new TicketNotFoundException());

        //Act and Assert
        var result = await _handler.Handle(request, CancellationToken.None);

        result.Code.Should().Be((int)Code.NOT_FOUND);
    }

    [Fact]
    public async Task Handle_ServiceUnavailable_WhenExceptionWasThrows()
    {
        //Arrange
        var request = new CancelTicketRequest() { TicketId = Guid.Parse("3dd3d868-541d-4275-9146-3b4449ffaa8c"), UserId = Guid.Parse("ee7fc2e2-27f1-4dba-b31f-1e98eaaa4f70") };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());


        _ticketServiceMock.Setup(s => s.CancelTicketAsync(request.UserId, request.TicketId)).ThrowsAsync(new Exception());

        //Act and Assert
        var result = await _handler.Handle(request, CancellationToken.None);

        result.Code.Should().Be((int)Code.SERVICE_UNAVAILABLE);
    }

}
