using FluentValidation;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.CUD.Get;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.Domain.interfaces;
using MGP.Discapacidad.Persistance.DTOs.Ticket;
using Moq;
using Xunit;
namespace MGP.Discapacidad.Test.Handler.User.CUD.GetByCode;

public class GetCudByCodeHandlerTest
{
    private readonly Mock<ITicketService> _ticketServiceMock;
    private readonly Mock<IValidator<GetTicketCudUserRequest>> _validatorMock;
    private readonly MessageManager _messageManager;
    private readonly GetTicketCudUserHandler _handler;

    public GetCudByCodeHandlerTest()
    {
        _ticketServiceMock = new Mock<ITicketService>();
        _validatorMock = new Mock<IValidator<GetTicketCudUserRequest>>();

        string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
        if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
        _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

        _handler = new GetTicketCudUserHandler(_ticketServiceMock.Object, _validatorMock.Object, _messageManager);
    }

    [Fact]
    public async Task Handle_ShouldReturnSuccess_WhenValidationSucceeds()
    {
        var request = new GetTicketCudUserRequest
        {
            TicketCode = "DS-DIS-039",
            UserId = Guid.NewGuid()
        };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
            .ReturnsAsync(new FluentValidation.Results.ValidationResult());

        var ticketData = new GetTicketCudData
        {
            Ticket = new TicketData()
            {
                TicketCode = request.TicketCode
            }
        };

        _ticketServiceMock.Setup(s => s.GetTicketCudUserAsync(request.UserId, request.TicketId, request.TicketCode))
            .ReturnsAsync(ticketData);

        var result = await _handler.Handle(request, CancellationToken.None);

        Assert.Equal((int)Code.SUCCESS, result.Code);
        Assert.Equal(ticketData.Ticket.TicketCode, result.Data.Ticket.TicketCode);
        Assert.Null(result.ErrorMessage);
    }

    [Fact]
    public async Task Handle_ShouldReturnBadRequest_WhenParametersAreMissing()
    {
        var request = new GetTicketCudUserRequest
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
        var request = new GetTicketCudUserRequest
        {
            TicketCode = "DS-DIS-039",
            UserId = Guid.NewGuid()
        };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
            .ReturnsAsync(new FluentValidation.Results.ValidationResult());

        _ticketServiceMock.Setup(s => s.GetTicketCudUserAsync(request.UserId, request.TicketId, request.TicketCode))
            .Throws(new TicketNotFoundException());

        var result = await _handler.Handle(request, CancellationToken.None);

        Assert.Equal((int)Code.NOT_FOUND, result.Code);
        Assert.NotNull(result.ErrorMessage);
    }

    [Fact]
    public async Task Handle_ShouldReturnServiceUnavailable_WhenAnUnexpectedErrorOccurs()
    {
        var request = new GetTicketCudUserRequest
        {
            TicketCode = "DS-DIS-039",
            UserId = Guid.NewGuid()
        };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
            .ReturnsAsync(new FluentValidation.Results.ValidationResult());

        _ticketServiceMock.Setup(s => s.GetTicketCudUserAsync(request.UserId, request.TicketId, request.TicketCode))
            .Throws(new Exception("Some unexpected error"));

        var result = await _handler.Handle(request, CancellationToken.None);

        Assert.Equal((int)Code.SERVICE_UNAVAILABLE, result.Code);
        Assert.NotNull(result.ErrorMessage);
    }
}
