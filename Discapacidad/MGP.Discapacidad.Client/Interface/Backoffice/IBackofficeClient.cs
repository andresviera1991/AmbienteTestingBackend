using MGP.Discapacidad.Client.DTOs.Response;
using System;
using System.Threading.Tasks;
namespace MGP.Discapacidad.Client.Interface.Backoffice;

public interface IBackofficeClient
{
    Task<Guid?> GetNextAvailableAgentAsync(string ticketType);

    Task<AgentData> GetAgentDataAsync(Guid agentId);

}
