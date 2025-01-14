using AutoMapper;
using FluentValidation;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.CUD.Get;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.PARKING.Get;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.SUBE.Get;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.Domain.interfaces;
using MGP.Discapacidad.Persistance.DTOs.Ticket;
using Moq;
using Xunit;
namespace MGP.Discapacidad.Test.Handler.User.SUBE.GetByCode;

public class GetSubeByCodeHandlerTest
{
    private readonly Mock<ITicketService> _ticketServiceMock;
    private readonly Mock<IValidator<GetTicketSubeUserRequest>> _validatorMock;
    private readonly MessageManager _messageManager;
    private readonly GetTicketSubeUserHandler _handler;
    private readonly Mock<IMapper> _mapperMock;

    public GetSubeByCodeHandlerTest()
    {
        _ticketServiceMock = new Mock<ITicketService>();
        _validatorMock = new Mock<IValidator<GetTicketSubeUserRequest>>();
        _mapperMock = new Mock<IMapper>();
        string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
        if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
        _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

        _handler = new GetTicketSubeUserHandler(_ticketServiceMock.Object, _validatorMock.Object, _messageManager,_mapperMock.Object );
    }

    [Fact]
    public async Task Handle_ShouldReturnSuccess_WhenValidationSucceeds()
    {
        var request = GetTicketSubeRequestObject();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
            .ReturnsAsync(new FluentValidation.Results.ValidationResult());

        var requestData = TicketSubeData();

        _ticketServiceMock.Setup(s => s.GetTicketSubeUserAsync(request.UserId, request.TicketId, request.TicketCode))
            .ReturnsAsync(requestData);

        var result = await _handler.Handle(request, CancellationToken.None);

        Assert.Equal((int)Code.SUCCESS, result.Code);
        Assert.Null(result.ErrorMessage);
    }

    [Fact]
    public async Task Handle_ShouldReturnBadRequest_WhenParametersAreMissing()
    {
        var request = GetTicketSubeRequestObject();
        request.TicketId = Guid.Empty;

        var validationResult = new FluentValidation.Results.ValidationResult
        {
            Errors = { new FluentValidation.Results.ValidationFailure("TicketId", "Ticket Id cannot be null.") }
        };
        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(validationResult);

        var result = await _handler.Handle(request, CancellationToken.None);

        Assert.Equal((int)Code.BAD_REQUEST, result.Code);
        Assert.NotNull(result.ErrorMessage);
    }

    [Fact]
    public async Task Handle_ShouldReturnNotFound_WhenTicketDoesNotExist()
    {
        var request = GetTicketSubeRequestObject();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
            .ReturnsAsync(new FluentValidation.Results.ValidationResult());

        _ticketServiceMock.Setup(s => s.GetTicketSubeUserAsync(request.UserId, request.TicketId, request.TicketCode))
            .Throws(new TicketNotFoundException());

        var result = await _handler.Handle(request, CancellationToken.None);

        Assert.Equal((int)Code.NOT_FOUND, result.Code);
        Assert.NotNull(result.ErrorMessage);
    }

    [Fact]
    public async Task Handle_ShouldReturnServiceUnavailable_WhenAnUnexpectedErrorOccurs()
    {
        var request = GetTicketSubeRequestObject();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
            .ReturnsAsync(new FluentValidation.Results.ValidationResult());

        _ticketServiceMock.Setup(s => s.GetTicketSubeUserAsync(request.UserId, request.TicketId, request.TicketCode))
            .Throws(new Exception("Some unexpected error"));

        var result = await _handler.Handle(request, CancellationToken.None);

        Assert.Equal((int)Code.SERVICE_UNAVAILABLE, result.Code);
        Assert.NotNull(result.ErrorMessage);
    }

    private static GetTicketSubeUserRequest GetTicketSubeRequestObject()
    {
        return new GetTicketSubeUserRequest
        {
            TicketCode = "DS-DIS-039",
            UserId = Guid.NewGuid()
        };
    }

    private static GetTicketSubeData TicketSubeData()
    {
        return new GetTicketSubeData
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
