using Confluent.Kafka;
using FluentAssertions;
using MGP.Discapacidad.Domain.Services;
using MGP.Discapacidad.Persistance.DTOs;
using Moq;
using Xunit;
using System.Text.Json;
namespace MGP.Discapacidad.Test.Service;

public class NotificationServiceTests
{
    private readonly Mock<IProducer<Null, string>> _producerMock;
    private readonly NotificationService _notificationService;

    public NotificationServiceTests()
    {
        _producerMock = new Mock<IProducer<Null, string>>();
        _notificationService = new NotificationService(_producerMock.Object);
    }

    [Fact]
    public async Task SendNotification_ShouldSerializeNotificationData_AndCallProduceAsync()
    {
        // Arrange
        var notificationData = new NotificationData(Guid.NewGuid(), "New Notification", "1", 1);

        string expectedSerializedData = JsonSerializer.Serialize(notificationData);

        _producerMock
            .Setup(p => p.ProduceAsync(
                "notification",
                It.Is<Message<Null, string>>(m => m.Value == expectedSerializedData),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(new DeliveryResult<Null, string>());

        // Act
        Func<Task> act = async () => await _notificationService.SendNotification(notificationData);

        // Assert
        await act.Should().NotThrowAsync();
        _producerMock.Verify(p => p.ProduceAsync(
            "notification",
            It.Is<Message<Null, string>>(m => m.Value == expectedSerializedData),
            It.IsAny<CancellationToken>()), Times.Once);

        _producerMock.Verify(p => p.Flush(It.IsAny<TimeSpan>()), Times.Once);
    }

    [Fact]
    public async Task SendNotification_ShouldCallFlushAfterProducingMessage()
    {
        // Arrange
        var notificationData = new NotificationData(Guid.NewGuid(), "Test Notification", "Message content", 1);

        _producerMock
            .Setup(p => p.ProduceAsync(It.IsAny<string>(), It.IsAny<Message<Null, string>>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new DeliveryResult<Null, string>());

        // Act
        await _notificationService.SendNotification(notificationData);

        // Assert
        _producerMock.Verify(p => p.Flush(It.IsAny<TimeSpan>()), Times.Once);
    }
}