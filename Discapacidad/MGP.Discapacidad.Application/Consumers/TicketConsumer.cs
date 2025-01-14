using Confluent.Kafka;
using MGP.Discapacidad.Domain.interfaces;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using System.Threading;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace MGP.Discapacidad.Application.Consumers;

public class TicketConsumer : BackgroundService
{
    private readonly ILogger<TicketConsumer> _logger;
    private readonly IConsumer<Ignore, string> _consumer;
    private readonly IServiceProvider _serviceProvider;
    public const int TICKETCERRADO = 8;

    public TicketConsumer(ILogger<TicketConsumer> logger, IConsumer<Ignore, string> consumer, IServiceProvider serviceProvider)
    {
        _logger = logger;
        _consumer = consumer;
        _consumer.Subscribe("delete-user");
        _serviceProvider = serviceProvider;
    }

    private async Task DeleteTicketsForUserAsync(Guid userId)
    {
        string message = $"Deleting tickets for user {userId}";
        _logger.LogInformation(message);

        using (var scope = _serviceProvider.CreateScope())
        {
            var ticketService = scope.ServiceProvider.GetRequiredService<ITicketService>();
            await ticketService.UpdateAllTicketStatusesAsync(userId, TICKETCERRADO);
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

                    var message = JsonSerializer.Deserialize<Dictionary<string, Guid>>(cr.Message.Value);
                    var userId = message["UserId"];
                    _ = DeleteTicketsForUserAsync(userId);
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