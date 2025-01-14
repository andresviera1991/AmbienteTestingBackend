using Confluent.Kafka;
using MGP.Discapacidad.Domain.interfaces;
using MGP.Discapacidad.Persistance.DTOs;
using System;
using System.Text.Json;
using System.Threading.Tasks;
namespace MGP.Discapacidad.Domain.Services;
public class NotificationService : INotificationService
{
    private readonly IProducer<Null, string> _producer;

    public NotificationService(IProducer<Null, string> producer)
    {
        _producer = producer;
    }

    public async Task SendNotification(NotificationData notificationData)
    {
        try
        {
            await _producer.ProduceAsync("notification", new Message<Null, string>
            {
                Value = JsonSerializer.Serialize(notificationData)
            });
        }
        finally
        {
            _producer.Flush(TimeSpan.FromSeconds(10));
        }
    }
}

