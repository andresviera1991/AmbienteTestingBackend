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

public class UnassignTicketConsumer : BackgroundService
{
    private readonly ILogger<UnassignTicketConsumer> _logger;
    private readonly IConsumer<Ignore, string> _consumer;
    private readonly IServiceProvider _serviceProvider;
    public const int TICKETCERRADO = 5;

    public UnassignTicketConsumer(ILogger<UnassignTicketConsumer> logger, IConsumer<Ignore, string> consumer, IServiceProvider serviceProvider)
    {
        _logger = logger;
        _consumer = consumer;
        _consumer.Subscribe("unassign-ticket");
        _serviceProvider = serviceProvider;
    }

    private async Task UnassignTicketAsync(Guid agentId)
    {
        string message = $"Update tickets for user {agentId}";
        _logger.LogInformation(message);

        using var scope = _serviceProvider.CreateScope();
        var ticketService = scope.ServiceProvider.GetRequiredService<ITicketService>();
        await ticketService.ReassignTicketAsync(agentId);
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
                    var agentId = message["UserId"];
                    _ = UnassignTicketAsync(agentId);
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