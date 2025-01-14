using Confluent.Kafka;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using System.Threading;
using System;
using Microsoft.Extensions.DependencyInjection;
using MGP.Audit.Domain.interfaces;
using MGP.Audit.Persistance.DTOs.Audit;

namespace MGP.Audit.Application.Consumers
{
    public class AuditConsumer : BackgroundService
    {
        private readonly ILogger<AuditConsumer> _logger;
        private readonly IConsumer<Ignore, string> _consumer;
        private readonly IServiceProvider _serviceProvider;

        public AuditConsumer(ILogger<AuditConsumer> logger, IConsumer<Ignore, string> consumer, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _consumer = consumer;
            _consumer.Subscribe("create-audit");
            _serviceProvider = serviceProvider;
        }

        private async Task CreateAuditAsync(AuditData auditData)
        {
            string message = $"Creating audit {auditData}";
            _logger.LogInformation(message);

            using (var scope = _serviceProvider.CreateScope())
            {
                var auditService = scope.ServiceProvider.GetRequiredService<IAuditService>();
                await auditService.CreateAuditAsync(auditData);
            }
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await Task.Run(() => ConsumeMessages(stoppingToken), stoppingToken);
        }

        private void ConsumeMessages(CancellationToken stoppingToken)
        {
            try
            {
                while (!stoppingToken.IsCancellationRequested)
                {
                    try
                    {
                        var cr = _consumer.Consume(stoppingToken);
                        string message1 = $"Received message: {cr.Message.Value}";
                        _logger.LogInformation(message1);

                        var message = JsonSerializer.Deserialize<Dictionary<string, object>>(cr.Message.Value);

                        if (message != null &&
                            message.TryGetValue("Id", out var id) &&
                            message.TryGetValue("UserId", out var userId) &&
                            message.TryGetValue("Action", out var action) &&
                            message.TryGetValue("Timestamp", out var timestamp) &&
                            message.TryGetValue("EntityType", out var entityType) &&
                            message.TryGetValue("EntityId", out var entityId) &&
                            message.TryGetValue("OldValue", out var oldValue) &&
                            message.TryGetValue("NewValue", out var newValue) &&
                            message.TryGetValue("MicroserviceName", out var microserviceName))
                        {
                            var auditData = new AuditData
                            {
                                Id = Guid.Parse(id.ToString()),
                                UserId = Guid.Parse(userId.ToString()),
                                Action = action.ToString(),
                                Timestamp = cr.Message.Timestamp.UtcDateTime,
                                EntityType = entityType.ToString(),
                                EntityId = entityId.ToString(),
                                OldValue = oldValue?.ToString(),
                                NewValue = newValue?.ToString(),
                                MicroserviceName = microserviceName.ToString()
                            };

                            _ = CreateAuditAsync(auditData);
                        }
                        else
                        {
                            _logger.LogWarning("El mensaje no contiene todos los datos necesarios para crear AuditData.");
                        }
                    }
                    catch (ConsumeException e)
                    {
                        string message = $"Error occurred: {e.Error.Reason}";
                        _logger.LogError(e, message);
                    }
                    catch (JsonException jsonEx)
                    {
                        string message = $"JSON deserialization error: {jsonEx.Message}";
                        _logger.LogError(jsonEx, message);
                    }
                }
            }
            finally
            {
                _consumer.Close();
            }
        }
    }
}