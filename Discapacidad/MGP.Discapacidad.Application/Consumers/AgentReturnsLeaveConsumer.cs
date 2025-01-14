using Confluent.Kafka;
using MGP.Discapacidad.Domain.interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace MGP.Discapacidad.Application.Consumers;
public class AgentReturnsLeaveConsumer : BackgroundService
{
    private readonly ILogger<AgentReturnsLeaveConsumer> _logger;
    private readonly IConsumer<Ignore, string> _consumer;
    private readonly IServiceProvider _serviceProvider;

    public AgentReturnsLeaveConsumer(ILogger<AgentReturnsLeaveConsumer> logger, IConsumer<Ignore, string> consumer, IServiceProvider serviceProvider)
    {
        _logger = logger;
        _consumer = consumer;
        _consumer.Subscribe("discapacidad-agent-leave");
        _serviceProvider = serviceProvider;
    }

    private async Task AgentReturnsAsync(Guid agentId, List<string> backupAgentList)
    {
        string message = $"Agent leave";
        _logger.LogInformation(message);

        using (var scope = _serviceProvider.CreateScope())
        {
            var ticketService = scope.ServiceProvider.GetRequiredService<ITicketService>();
            await ticketService.UpdateAgentAssignedAsync(agentId, backupAgentList);
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

                    var message = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(cr.Message.Value);
                    var agentId = message["AgentId"].GetGuid();
                    var backupAgentList = message["BackupAgentList"].EnumerateArray().Select(x => x.GetString()).ToList();

                    _ = AgentReturnsAsync(agentId, backupAgentList);
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
