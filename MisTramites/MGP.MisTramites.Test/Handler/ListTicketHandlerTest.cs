using AutoMapper;
using FluentValidation;
using MGP.MisTramites.Application.UseCase.V1.User.ListTickets;
using MGP.MisTramites.Client.DTOs.Response.ListTicket;
using MGP.MisTramites.CrossCutting.Helpers;
using MGP.MisTramites.CrossCutting.Messages;
using MGP.MisTramites.CrossCutting.MessagesManager;
using MGP.MisTramites.Domain.Interfaces;
using Moq;
namespace MGP.MisTramites.Test.Handler;

public class ListTicketHandlerTest
{
    private readonly Mock<IValidator<ListTicketUserRequest>> _validatorMock;
    private readonly Mock<ITicketService> _ticketServiceMock;
    private readonly MessageManager _messageManagerMock;
    private readonly ListTicketsHandler _listTicketsHandler;
    private readonly Mock<IMapper> _mapperMock;
    public ListTicketHandlerTest()
    {
        _validatorMock = new Mock<IValidator<ListTicketUserRequest>>();

        string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
        if (!Directory.Exists(testPath))
        {
            Directory.CreateDirectory(testPath);
        }

        _messageManagerMock = new MessageManager(new ErrorMessagesProvider(testPath));
        _ticketServiceMock = new Mock<ITicketService>();
        _mapperMock = new Mock<IMapper>();

        _listTicketsHandler = new ListTicketsHandler(_ticketServiceMock.Object, _messageManagerMock, _validatorMock.Object, _mapperMock.Object);
    }

    [Fact]
    public async Task HandlerShouldReturnSuccess_WhenUserIdIsCorrect()
    {
        Guid userId = Guid.NewGuid();

        //1) Defino el list ticket requet
        ListTicketUserRequest listTicketsRequest = new()
        {
            UserId = userId
        };

        //2) valido el input
        _validatorMock.Setup(v => v.ValidateAsync(listTicketsRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

        //3) Defino el ticket data

        List<TicketData> ListTicketData =
        [
            new()
            {
            UserId = userId,
            CreationDate = DateTime.Now,
            TicketCode = "2",
            TicketStatus = null,
            TicketType = null,
            Id = Guid.Parse("23d62fe5-8b4c-44b2-857c-61734a4e7aa5")
            }
        ];

        //4) llamo al metodo de listar

        //Act
        var result = await _listTicketsHandler.Handle(listTicketsRequest, CancellationToken.None);

        //Assert
        Assert.Equal((int)Code.Success, result.Code);
        Assert.Null(result.Message);
    }

    [Fact]
    public async Task HandlerShouldThrowInvalidParameterException_WhenUserIdIsNotProvider()
    {
        //1) Defino el list ticket requet
        ListTicketUserRequest listTicketsRequest = new()
        {

            UserId = Guid.Empty
        };

        //2) valido el input
        var validationResult = new FluentValidation.Results.ValidationResult
        {
            Errors = { new FluentValidation.Results.ValidationFailure("New Password", _messageManagerMock.GetNotification(FunctionalMessages.NOT_NULL, nameof(listTicketsRequest.UserId))) }
        };

        _validatorMock.Setup(v => v.ValidateAsync(listTicketsRequest, It.IsAny<CancellationToken>())).ReturnsAsync(validationResult);

        // Act
        var result = await _listTicketsHandler.Handle(listTicketsRequest, CancellationToken.None);

        // Assert
        Assert.Equal((int)Code.BadRequest, result.Code);

    }

    [Fact]
    public async Task HandlerThrowException_WhenError()
    {
        Guid userId = Guid.NewGuid();

        //1) Defino el list ticket requet
        ListTicketUserRequest listTicketsRequest = new()
        {
            UserId = userId
        };

        //2) valido el input
        _validatorMock.Setup(v => v.ValidateAsync(listTicketsRequest, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

        //3) Defino el ticket data

        // Act
        var result = await _listTicketsHandler.Handle(listTicketsRequest, CancellationToken.None);

        // Assert
        Assert.Equal((int)Code.ServiceUnavailable, result.Code);
    }
}