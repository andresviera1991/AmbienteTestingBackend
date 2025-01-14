using FluentAssertions;
using MGP.Discapacidad.CrossCutting.Enum;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.Domain.Services;
using MGP.Discapacidad.Persistance.Interface;
using Moq;
using Xunit;
namespace MGP.Discapacidad.Test.Service;

public class EmailServiceTests
{
    private readonly Mock<IEmailRepository> _emailRepositoryMock;
    private readonly EmailService _emailService;

    public EmailServiceTests()
    {
        _emailRepositoryMock = new Mock<IEmailRepository>();
        _emailService = new EmailService(_emailRepositoryMock.Object);
    }

    [Fact]
    public async Task GetEmailTemplateAsync_ShouldReturnTemplate_WhenExists()
    {
        // Arrange
        var emailTemplate = EmailTemplateEnum.NEW_TICKET_ACTIVITY; // Asumiendo que esta plantilla está definida en el enum
        string expectedTemplate = "Template content";

        _emailRepositoryMock
            .Setup(x => x.GetEmailTemplateAsync(emailTemplate))
            .ReturnsAsync(expectedTemplate); // Simulando que el repositorio devuelve una plantilla

        // Act
        var result = await _emailService.GetEmailTemplateAsync(emailTemplate);

        // Assert
        result.Should().Be(expectedTemplate); // Verifica que el resultado coincida con la plantilla esperada
    }

    [Fact]
    public async Task GetEmailTemplateAsync_ShouldThrowException_WhenRepositoryFails()
    {
        // Arrange
        var emailTemplate = EmailTemplateEnum.NEW_TICKET_ACTIVITY; // Plantilla que queremos obtener

        _emailRepositoryMock
            .Setup(x => x.GetEmailTemplateAsync(emailTemplate))
            .ThrowsAsync(new Exception("Template not found")); // Simulamos que el repositorio lanza una excepción

        // Act
        Func<Task> act = async () => await _emailService.GetEmailTemplateAsync(emailTemplate);

        // Assert
        await act.Should().ThrowAsync<Exception>(); // Verifica que se lanza una excepción al obtener la plantilla
    }

    [Fact]
    public async Task SendEmailHandlerAsync_ShouldSendEmailSuccessfully_WhenNoErrors()
    {
        // Arrange
        string email = "cristian.fer.mel@gmail.com";
        string subject = "Test Subject";
        string emailBody = "Test email body";

        _emailRepositoryMock
            .Setup(x => x.GetEmailTemplateAsync(It.IsAny<EmailTemplateEnum>()))
            .ReturnsAsync("Template content");

        // Act
        Func<Task> act = async () => await _emailService.SendEmailHandlerAsync(email, subject, emailBody);

        // Assert
        await act.Should().NotThrowAsync();
    }

    [Fact]
    public async Task SendEmailHandlerAsync_ShouldThrowEmailException_WhenSmtpFails()
    {
        // Arrange
        string email = "test@example.com";
        string subject = "Test Subject";
        string emailBody = "Test email body";

        _emailRepositoryMock
            .Setup(x => x.GetEmailTemplateAsync(It.IsAny<EmailTemplateEnum>()))
            .ReturnsAsync("Template content");

        // Act
        Func<Task> act = async () => await _emailService.SendEmailHandlerAsync(email, subject, emailBody);

        // Assert
        await act.Should().ThrowAsync<EmailException>(); // Verifica que se lanza una excepción al obtener la plantilla
    }
}