using FluentAssertions;
using Moq;
using MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.COUNT;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.Domain.interfaces;
using Xunit;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.Persistance.DTOs.Ticket;
using MGP.Discapacidad.Persistance.DTOs.Catalog;
using MGP.Discapacidad.Client.DTOs.Response;
namespace MGP.Discapacidad.Test.Handler.Agent.COUNT;

public class CountTicketsByAgentHandlerTest
{
    private readonly Mock<ITicketService> _ticketServiceMock;
    private readonly MessageManager _messageManager;
    private readonly CountTicketsByAgentHandler _handler;

    public CountTicketsByAgentHandlerTest()
    {
        _ticketServiceMock = new Mock<ITicketService>();

        string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
        if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
        _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

        _handler = new CountTicketsByAgentHandler(_ticketServiceMock.Object, _messageManager);
    }

    [Fact]
    public async Task Handle_ShouldReturnSuccessResponse_WhenTicketsAreCountedSuccessfully()
    {
        // Arrange 
        var countTicketsByAgent = CreateCountTicketsResponse();
        _ticketServiceMock.Setup(x => x.CountTicketByAgentAsync()).ReturnsAsync(countTicketsByAgent);

        var request = new CountTicketsByAgentRequest();
        var cancellationToken = CancellationToken.None;

        // Act
        var result = await _handler.Handle(request, cancellationToken);

        // Assert
        result.Code.Should().Be((int)Code.SUCCESS);
        result.Data.CountTicketData.Count.Should().Be(1);
        result.ErrorMessage.Should().BeNull();
    }

    [Fact]
    public async Task Handle_ShouldReturnServiceUnavailable_WhenUnexpectedExceptionIsThrown()
    {
        // Arrange
        _ticketServiceMock.Setup(x => x.CountTicketByAgentAsync()).Throws<Exception>();

        var request = new CountTicketsByAgentRequest();
        var cancellationToken = CancellationToken.None;

        // Act
        var result = await _handler.Handle(request, cancellationToken);

        // Assert
        result.Code.Should().Be((int)Code.SERVICE_UNAVAILABLE);
        result.Data.Should().BeNull();
    }

    private List<CountTicketByAgentData> CreateCountTicketsResponse()
    {
        var agentData = new AgentData()
        {
            FirstName = "Juan",
            LastName = "López",
            Id = Guid.NewGuid(),
        };

        List<TicketStatusQuantityData> ticketStatusQuantity = new List<TicketStatusQuantityData>
        {
            new TicketStatusQuantityData {
                Quantity = 5,
                TicketStatus = new TicketStatusData()
                {
                Id = 1,
                Name = "New"
                }
            }
        };

        List<CountTicketByAgentData> countTicketByAgentData = new List<CountTicketByAgentData>()
        {
            new()
            {
                Agent = agentData,
                AgentId = agentData.Id,
                TicketStatusQuantity = ticketStatusQuantity
            }
        };

        return countTicketByAgentData;
    }
}