using Confluent.Kafka;
using MGP.Authentication.Domain.Interfaces;
using MGP.Authentication.Persistance.DTOs;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace MGP.Authentication.Domain.Services
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

        public async Task DeleteTickets(Guid id)
        {
            try
            {
                await _producer.ProduceAsync("delete-user", new Message<Null, string>
                {
                    Value = JsonSerializer.Serialize(new { UserId = id })
                });
            }
            finally
            {
                _producer.Flush(TimeSpan.FromSeconds(10));
            }
        }
    }
}
