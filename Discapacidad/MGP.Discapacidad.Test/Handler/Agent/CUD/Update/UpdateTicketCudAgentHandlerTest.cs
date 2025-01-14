﻿using AutoMapper;
using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.CUD.Get;
using MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.CUD.Update;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.Domain.interfaces;
using MGP.Discapacidad.Persistance.DTOs.Ticket;
using Moq;
using Xunit;
namespace MGP.Discapacidad.Test.Handler.Agent.CUD.Update;

public class UpdateTicketCudAgentHandlerTest
{
    private readonly Mock<ITicketService> _ticketServiceMock;
    private readonly Mock<IValidator<UpdateTicketCudRequest>> _validatorMock;
    private readonly MessageManager _messageManager;
    private readonly Mock<IMapper> _mapperMock;
    private readonly UpdateTicketCudHandler _handler;

    public UpdateTicketCudAgentHandlerTest()
    {
        _ticketServiceMock = new Mock<ITicketService>();
        _validatorMock = new Mock<IValidator<UpdateTicketCudRequest>>();
        _mapperMock = new Mock<IMapper>();

        string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
        if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
        _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

        _handler = new UpdateTicketCudHandler(
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
        var request = UpdateTicketCudRequest();
        var updatedData = UpdateTicketCudData();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new FluentValidation.Results.ValidationResult());

        _mapperMock.Setup(m => m.Map<UpdateTicketCudData>(request)).Returns(updatedData);

        _ticketServiceMock.Setup(ts => ts.UpdateTicketCudAsync(updatedData)).Returns(Task.CompletedTask);

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
        var request = UpdateTicketCudRequest();

        var validationResult = new ValidationResult
        {
            Errors = [new ValidationFailure("TicketId", _messageManager.GetNotification(FunctionalMessages.NOT_NULL, nameof(GetTicketCudAgentRequest.TicketId)))]
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
        var request = UpdateTicketCudRequest();
        var requestData = UpdateTicketCudData();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _mapperMock.Setup(m => m.Map<UpdateTicketCudData>(request)).Returns(requestData);

        _ticketServiceMock.Setup(s => s.UpdateTicketCudAsync(requestData)).Throws(new TicketNotFoundException());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.NOT_FOUND);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.TICKET_NOT_FOUND));
    }

    [Fact]
    public async Task Handle_Should_Return_InvalidDate_When_MedicalCommitteDateIsInvalid()
    {
        // Arrange
        var request = UpdateTicketCudRequest();
        var requestData = UpdateTicketCudData();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _mapperMock.Setup(m => m.Map<UpdateTicketCudData>(request)).Returns(requestData);

        _ticketServiceMock.Setup(s => s.UpdateTicketCudAsync(requestData)).Throws(new InvalidMedicalCommitteDateException());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.BAD_REQUEST);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.INVALID_DATE));
    }

    [Fact]
    public async Task Handle_Should_Return_TicketStatusNotFoundException_When_TicketStatusIsNotValid()
    {
        // Arrange
        var request = UpdateTicketCudRequest();
        var requestData = UpdateTicketCudData();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _mapperMock.Setup(m => m.Map<UpdateTicketCudData>(request)).Returns(requestData);

        _ticketServiceMock.Setup(s => s.UpdateTicketCudAsync(requestData)).Throws(new TicketStatusNotFoundException());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.NOT_FOUND);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.TICKET_STATUS_NOT_FOUND));
    }

    [Fact]
    public async Task Handle_Should_Return_Exception_When_ServiceIsUnavailable()
    {
        // Arrange
        var request = UpdateTicketCudRequest();
        var requestData = UpdateTicketCudData();

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());

        _mapperMock.Setup(m => m.Map<UpdateTicketCudData>(request)).Returns(requestData);

        _ticketServiceMock.Setup(s => s.UpdateTicketCudAsync(requestData)).Throws(new Exception());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.SERVICE_UNAVAILABLE);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE));
    }

    private static UpdateTicketCudRequest UpdateTicketCudRequest()
    {
        return new UpdateTicketCudRequest()
        {
            TicketId = Guid.Parse("96949bb8-8c14-466d-b34f-3c9d491dd96a"),
            Certificate = false,
            DocumentComplete = false,
            HealthInsurance = false,
            ExpiredCertificate = false,
            LostCertificate = false,
            PaySlip = true,
            CertificateExpansionOptionsId = 1,
            GDECode = null,
            MedicalCommitteDate = null,
            SignatureOptionsId = 2,
            TicketStatusId = 3,
            UpdateDocumentStatus = null,
            UserEmail = ""
        };
    }

    private static UpdateTicketCudData UpdateTicketCudData()
    {
        return new UpdateTicketCudData()
        {
            TicketId = Guid.Parse("96949bb8-8c14-466d-b34f-3c9d491dd96a"),
            Certificate = false,
            DocumentComplete = false,
            HealthInsurance = false,
            ExpiredCertificate = false,
            LostCertificate = false,
            PaySlip = true,
            CertificateExpansionOptionsId = 1,
            GDECode = null,
            MedicalCommitteDate = null,
            SignatureOptionsId = 2,
            TicketStatusId = 3,
            UpdateDocumentStatus = null,
            UserEmail = ""
        };
    }
}
