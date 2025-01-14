using MGP.Backoffice.Domain.DTOs;

namespace MGP.Backoffice.Domain.Interface
{
    public interface IAgentLeaveService
    {
        Task<AgentLeaveData> CreateAgentLeaveAsync(AgentLeaveData agentLeaveData);
        Task<List<AgentLeaveData>> GetAgentLeaveByAgentIdAsync(Guid agentId);
        Task<AgentLeaveData> PatchAgentLeaveAsync(AgentLeaveDataToUpdate agentLeaveToUpdate);
    }
}
