using Confluent.Kafka;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using System.Threading;
using System;
using Microsoft.Extensions.DependencyInjection;
using MGP.Notifications.Domain.interfaces;
using MGP.Notifications.Persistance.DTOs.Notifications;

namespace MGP.Notifications.Application.Consumers
{
    public class NotificationsConsumer : BackgroundService
    {
        private readonly ILogger<NotificationsConsumer> _logger;
        private readonly IConsumer<Ignore, string> _consumer;
        private readonly IServiceProvider _serviceProvider;

        public NotificationsConsumer(ILogger<NotificationsConsumer> logger, IConsumer<Ignore, string> consumer, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _consumer = consumer;
            _consumer.Subscribe("notification");
            _serviceProvider = serviceProvider;
        }

        private async Task CreateNotificationsAsync(NotificationData NotificationData)
        {
            string message = $"Creating Notifications {NotificationData}";
            _logger.LogInformation(message);

            using (var scope = _serviceProvider.CreateScope())
            {
                var notificationsService = scope.ServiceProvider.GetRequiredService<INotificationsService>();
                await notificationsService.CreateNotificationsAsync(NotificationData);
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
                            message.TryGetValue("UserId", out var userId) &&
                            message.TryGetValue("Message", out var description) &&
                            message.TryGetValue("URL", out var url) &&
                            message.TryGetValue("NotificationTypeId", out var notificationTypeId))
                        {
                            var NotificationsData = new NotificationData
                            {
                                UserId = Guid.Parse(userId.ToString()),
                                Message = description.ToString(),
                                URL = url.ToString(),
                                NotificationTypeId = int.Parse(notificationTypeId.ToString()),
                                Read = false
                            };

                            _ = CreateNotificationsAsync(NotificationsData);
                        }
                        else
                        {
                            _logger.LogWarning("El mensaje no contiene todos los datos necesarios para crear NotificationsData.");
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