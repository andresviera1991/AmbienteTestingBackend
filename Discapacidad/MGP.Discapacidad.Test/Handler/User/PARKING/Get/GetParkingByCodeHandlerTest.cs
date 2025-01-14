using FluentAssertions;
using FluentValidation;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.PARKING.Get;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.Domain.interfaces;
using MGP.Discapacidad.Persistance.DTOs.Ticket;
using Moq;
using Xunit;
namespace MGP.Discapacidad.Test.Handler.User.PARKING.GetByCode;

public class GetParkingByCodeHandlerTest
{
    private readonly Mock<ITicketService> _ticketServiceMock;
    private readonly Mock<IValidator<GetTicketParkingUserRequest>> _validatorMock;
    private readonly MessageManager _messageManager;
    private readonly GetTicketParkingUserHandler _handler;
    public GetParkingByCodeHandlerTest()
    {
        _ticketServiceMock = new Mock<ITicketService>();
        _validatorMock = new Mock<IValidator<GetTicketParkingUserRequest>>();

        string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
        if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
        _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

        _handler = new GetTicketParkingUserHandler(_ticketServiceMock.Object, _validatorMock.Object, _messageManager);
    }

    [Fact]
    public async Task Handle_ShouldReturnSuccess_WhenValidationSucceeds()
    {
        //Arrange
        var request = GetTicketParkingRequestObject();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

        var ticketData = TicketParkingData();

        _ticketServiceMock.Setup(s => s.GetTicketParkingUserAsync(request.UserId, request.TicketId, request.TicketCode)).ReturnsAsync(ticketData);

        //Act and Assert
        var result = await _handler.Handle(request, CancellationToken.None);

        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.SUCCESS);
        result.Data.Ticket.TicketCode.Should().Be("DS-DIS-039");

    }

    [Fact]
    public async Task Handle_ShouldReturnBadRequest_WhenParametersAreMissing()
    {
        var request = new GetTicketParkingUserRequest
        {
            UserId = Guid.NewGuid()
        };

        var validationResult = new FluentValidation.Results.ValidationResult
        {
            Errors = { new FluentValidation.Results.ValidationFailure("TicketCode", "Ticket code cannot be empty.") }
        };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(validationResult);

        var result = await _handler.Handle(request, CancellationToken.None);

        Assert.Equal((int)Code.BAD_REQUEST, result.Code);
        Assert.NotNull(result.ErrorMessage);
    }

    [Fact]
    public async Task Handle_ShouldReturnNotFound_WhenTicketDoesNotExist()
    {
        var request = new GetTicketParkingUserRequest
        {
            TicketCode = "DS-DIS-039",
            UserId = Guid.NewGuid()
        };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
            .ReturnsAsync(new FluentValidation.Results.ValidationResult());

        _ticketServiceMock.Setup(s => s.GetTicketParkingUserAsync(request.UserId, request.TicketId, request.TicketCode))
            .Throws(new TicketNotFoundException());

        var result = await _handler.Handle(request, CancellationToken.None);

        Assert.Equal((int)Code.NOT_FOUND, result.Code);
        Assert.NotNull(result.ErrorMessage);
    }

    [Fact]
    public async Task Handle_ShouldReturnServiceUnavailable_WhenAnUnexpectedErrorOccurs()
    {
        var request = new GetTicketParkingUserRequest
        {
            TicketCode = "DS-DIS-039",
            UserId = Guid.NewGuid()
        };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
            .ReturnsAsync(new FluentValidation.Results.ValidationResult());

        _ticketServiceMock.Setup(s => s.GetTicketParkingUserAsync(request.UserId, request.TicketId, request.TicketCode))
            .Throws(new Exception("Some unexpected error"));

        var result = await _handler.Handle(request, CancellationToken.None);

        Assert.Equal((int)Code.SERVICE_UNAVAILABLE, result.Code);
        Assert.NotNull(result.ErrorMessage);
    }

    private static GetTicketParkingUserRequest GetTicketParkingRequestObject()
    {
        return new GetTicketParkingUserRequest
        {
            TicketCode = "DS-DIS-039",
            UserId = Guid.NewGuid()
        };
    }

    private static GetTicketParkingData TicketParkingData()
    {
        return new GetTicketParkingData
        {
            Ticket = new TicketData
            {
                Id = Guid.NewGuid(),
                TicketCode = "DS-DIS-039",
                AgentData = null,
                UserData = null,
                AssignedAgentId = Guid.NewGuid(),
                GDECode = "AKLK4545",
                CreationDate = DateTime.Now,
                TicketStatus = null,
                TicketType = null,
                UserId = Guid.NewGuid(),
                Documents = []
            }

        };
    }

}
