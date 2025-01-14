using MGP.Backoffice.Persistance.Data.Tables;

namespace MGP.Backoffice.Persistance.Interfaces
{
    public interface IAgentLeaveRepository
    {
        Task<AgentLeave> GetAgentLeaveByIdAsync(Guid agentLeaveId);
        Task<List<AgentLeave>> FindByStartDateOrEndDateAsync();
        Task<AgentLeave> CreateAsync(AgentLeave agentLeave);
        Task<bool> AgentHasVacationAsync(Guid agentId, DateTime startDate, DateTime endDate);
        Task<List<AgentLeave>> AgentLeaveByAgentIdAsync(Guid agentId);
        Task<AgentLeave> UpdateAsync(AgentLeave agentLeaveToUpdate);
    }
}
