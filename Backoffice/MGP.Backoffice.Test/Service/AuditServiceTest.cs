using Confluent.Kafka;
using MGP.Backoffice.Domain.DTOs;
using MGP.Backoffice.Domain;
using Moq;
using Xunit;
using System.Text.Json;

namespace MGP.Backoffice.Test.Service
{
    public class AuditServiceTest
    {
        private readonly Mock<IProducer<Null, string>> _mockProducer;
        private readonly AuditService _auditService;

        public AuditServiceTest()
        {
            _mockProducer = new Mock<IProducer<Null, string>>();
            _auditService = new AuditService(_mockProducer.Object);
        }

        [Fact]
        public async Task SendAudit_ShouldProduceMessage_WhenCalled()
        {
            var auditData = new AuditData(Guid.NewGuid(),"TestAction","TestEntity","12345","{}","{}");

            await _auditService.SendAudit(auditData);

            var expectedMessage = JsonSerializer.Serialize(auditData);
            
            _mockProducer.Verify(producer => producer.ProduceAsync(
                "create-audit",
                It.Is<Message<Null, string>>(message =>
                    message.Value == expectedMessage
                ),
                default), Times.Once);

            _mockProducer.Verify(producer => producer.Flush(It.IsAny<TimeSpan>()), Times.Once);
        }

        [Fact]
        public async Task SendAudit_ShouldHandleException_WhenProducerFails()
        {
            var auditData = new AuditData(Guid.NewGuid(), "TestAction", "TestEntity", "12345", "{}", "{}");

            _mockProducer.Setup(p => p.ProduceAsync(It.IsAny<string>(), It.IsAny<Message<Null, string>>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(new KafkaException(new Error(ErrorCode.Unknown, "Kafka failure")));

            await Assert.ThrowsAsync<KafkaException>(async () => await _auditService.SendAudit(auditData));

            _mockProducer.Verify(producer => producer.Flush(It.IsAny<TimeSpan>()), Times.Once);
        }
    }
}