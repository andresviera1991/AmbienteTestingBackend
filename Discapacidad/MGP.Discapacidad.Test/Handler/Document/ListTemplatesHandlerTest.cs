using AutoMapper;
using FluentAssertions;
using FluentValidation;
using MGP.Discapacidad.Application.UseCase.V1.Document.AddTemplate;
using MGP.Discapacidad.Application.UseCase.V1.Document.ListTemplates;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.List.ListTicketByUser;
using MGP.Discapacidad.CrossCutting.Enum;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.Domain.interfaces;
using MGP.Discapacidad.Persistance.DTOs.Document;
using Moq;
using Xunit;
namespace MGP.Discapacidad.Test.Handler.Document;

public class ListTemplatesHandlerTest
{
    private readonly Mock<IDocumentService> _documentServiceMock;
    private readonly MessageManager _messageManager;
    private readonly ListTemplatesHandler _handler;

    public ListTemplatesHandlerTest()
    {
        _documentServiceMock = new Mock<IDocumentService>();

        string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
        if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
        _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

        _handler = new ListTemplatesHandler(
            _documentServiceMock.Object,
            _messageManager
        );
    }

    [Fact]
    public async Task Handle_Success_ReturnsResponseData()
    {
        // Arrange
        var request = new ListTemplatesRequest() { TicketTypeId = TicketTypeEnum.CUD };
        var templateData = GetTemplateDataObject();

        _documentServiceMock.Setup(ts => ts.ListTemplatesAsync(request.TicketTypeId)).ReturnsAsync(templateData);

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.SUCCESS);
        result.Data.Templates.Count.Should().Be(2);
    }

    [Fact]
    public async Task Handle_ServiceException_ReturnsServiceUnavailableResponse()
    {
        // Arrange
        var request = new ListTemplatesRequest() { TicketTypeId = TicketTypeEnum.CUD };

        _documentServiceMock.Setup(ts => ts.ListTemplatesAsync(request.TicketTypeId)).ThrowsAsync(new Exception());

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        result.Should().NotBeNull();
        result.Code.Should().Be((int)Code.SERVICE_UNAVAILABLE);
        result.ErrorMessage.Message.Should().Contain(_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE));
    }

    private List<ListTemplateData> GetTemplateDataObject()
    {
        return [ 
            new ListTemplateData() { TicketTypeId = TicketTypeEnum.CUD,
                                     CreationDate = DateTime.Now,
                                     DocumentPath = "PATH", Information = "Completa este formulario",
                                     Id = Guid.Parse("00526b63-5215-490f-9347-d24c00ccd235"),
                                     Name = "Patologías Diversas"},

            new ListTemplateData() { TicketTypeId = TicketTypeEnum.CUD,
                                     CreationDate = DateTime.Now,
                                     DocumentPath = "PATH", Information = "Completa este formulario",
                                     Id = Guid.Parse("00526b63-5215-490f-9347-d24c00ccd260"),
                                     Name = "Patologías Crónicas"},
        ];
    }

}
