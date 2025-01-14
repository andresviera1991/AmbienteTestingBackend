using FluentValidation;
using FluentValidation.Results;
using FluentAssertions;
using MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.CUD.Get;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.Domain.interfaces;
using MGP.Discapacidad.Persistance.DTOs.Ticket;
using Moq;
using Xunit;
namespace MGP.Discapacidad.Test.Handler.Agent.CUD.Get;

public class GetTicketCudAgentHandlerTest
{
    private readonly Mock<ITicketService> _ticketServiceMock;
    private readonly Mock<IValidator<GetTicketCudAgentRequest>> _validatorMock;
    private readonly MessageManager _messageManager;
    private readonly GetTicketCudAgentHandler _handler;

    public GetTicketCudAgentHandlerTest()
    {
        _ticketServiceMock = new Mock<ITicketService>();
        _validatorMock = new Mock<IValidator<GetTicketCudAgentRequest>>();

        string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
        if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
        _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

        _handler = new GetTicketCudAgentHandler(
            _ticketServiceMock.Object,
            _validatorMock.Object,
            _messageManager
        );
    }

    [Fact]
    public async Task Handle_Success_ReturnsResponseData()
    {
        // Arrange
        var request = new GetTicketCudAgentRequest { TicketId = Guid.Parse("96949bb8-8c14-466d-b34f-3c9d491dd96a"), TicketCode = "DS-DIS-1" };
        var ticketData = GetTicketCudData();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _ticketServiceMock.Setup(ts => ts.GetTicketCudAgentAsync(request.TicketId, request.TicketCode)).ReturnsAsync(ticketData);

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.SUCCESS);
        result.Data.Ticket.TicketCode.Should().Be(ticketData.Ticket.TicketCode);
    }

    [Fact]
    public async Task Handle_ValidationError_ThrowsParameterNotProviderException()
    {
        // Arrange
        var request = new GetTicketCudAgentRequest { };

        var validationResult = new ValidationResult
        {
            Errors =
                [
                    new ValidationFailure("TicketId", _messageManager.GetNotification(FunctionalMessages.NOT_NULL, nameof(GetTicketCudAgentRequest.TicketId))),
                    new ValidationFailure("TicketCode", _messageManager.GetNotification(FunctionalMessages.NOT_NULL, nameof(GetTicketCudAgentRequest.TicketCode)))
                ]
        };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(validationResult);

        // Act & Assert

        var result = await _handler.Handle(request, CancellationToken.None);

        result.Code.Should().Be((int)Code.BAD_REQUEST);
    }

    [Fact]
    public async Task Handle_NotFoundException_ReturnsNotFoundResponse()
    {
        // Arrange
        var request = new GetTicketCudAgentRequest { TicketId = Guid.Parse("96949bb8-8c14-466d-b34f-3c9d491dd96a"), TicketCode = "DS-DIS-1" };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _ticketServiceMock.Setup(ts => ts.GetTicketCudAgentAsync(request.TicketId, request.TicketCode)).ThrowsAsync(new TicketNotFoundException());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.NOT_FOUND);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.TICKET_NOT_FOUND));
    }

    [Fact]
    public async Task Handle_ServiceException_ReturnsServiceUnavailableResponse()
    {
        // Arrange
        var request = new GetTicketCudAgentRequest { TicketId = Guid.Parse("96949bb8-8c14-466d-b34f-3c9d491dd96a"), TicketCode = "DS-DIS-1" };

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _ticketServiceMock.Setup(ts => ts.GetTicketCudAgentAsync(request.TicketId, request.TicketCode)).ThrowsAsync(new Exception());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.SERVICE_UNAVAILABLE);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE));
    }

    private GetTicketCudData GetTicketCudData()
    {
        return new GetTicketCudData()
        {
            Id = Guid.Parse("96949bb8-8c14-466d-b34f-3c9d491dd96a"),
            Certificate = false,
            CertificateExpansionOptions = null,
            DocumentComplete = false,
            HealthInsurance = false,
            ExpiredCertificate = false,
            LostCertificate = false,
            MedicalCommitteData = null,
            PaySlip = true,
            SignatureOption = null,
            Ticket = new TicketData()
            {
                AgentData = null,
                UserData = null,
                AssignedAgentId = Guid.Parse("18d14490-91c1-4ba6-843c-9b501d187051"),
                CreationDate = DateTime.Now,
                Documents = null,
                Id = Guid.Parse("96949bb8-8c14-466d-b34f-3c9d491dd96a"),
                GDECode = null,
                TicketCode = "DS-DIS-1",
                TicketStatus = null,
                TicketType = null,
                UserId = Guid.Parse("3dd3d868-541d-4275-9146-3b4449ffaa8c")
            }

        };
    }
}
