using Confluent.Kafka;
using MGP.Backoffice.Domain.DTOs;
using MGP.Backoffice.Domain.Interface;
using System.Text.Json;

namespace MGP.Backoffice.Domain
{
    public class AuditService : IAuditService
    {
        private readonly IProducer<Null, string> _producer;

        public AuditService(IProducer<Null, string> producer)
        {
            _producer = producer;
        }

        public async Task SendAudit(AuditData auditData)
        {
            try
            {
                await _producer.ProduceAsync("create-audit", new Message<Null, string>
                {
                    Value = JsonSerializer.Serialize(auditData)
                });
            }
            finally
            {
                _producer.Flush(TimeSpan.FromSeconds(10));
            }
        }
    }
}
