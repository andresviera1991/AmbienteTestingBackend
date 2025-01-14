using MGP.Discapacidad.Client.DTOs.Request;
using MGP.Discapacidad.Client.DTOs.Response;
using MGP.Discapacidad.Client.Interface.Backoffice;
using System;
using System.Threading.Tasks;
namespace MGP.Discapacidad.Client;

public class BackofficeClient : IBackofficeClient
{
    private readonly IBackofficeApi _api;

    public BackofficeClient(IBackofficeApi api)
    {
        _api = api;
    }

    public async Task<AgentData> GetAgentDataAsync(Guid agentId)
    {
        try
        {
            var getAgentResponseModel = await _api.GetAgentData(agentId);
            return getAgentResponseModel.Content.Data ?? null;
        }
        catch (Exception)
        {
            return null;
        }
   
    }

    public async Task<Guid?> GetNextAvailableAgentAsync(string ticketType)
    {
        var nextAvailableAgentResponseModel = await _api.GetNextAvailableAgent(new NextAvailableAgentRequestModel() { Area = "DISCAPACIDAD", TicketType = ticketType });
        return nextAvailableAgentResponseModel.Content.Data != null ? nextAvailableAgentResponseModel.Content.Data.Id : null;
    }
}