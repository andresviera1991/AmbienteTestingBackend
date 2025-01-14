using MGP.Backoffice.CrossCutting.Exceptions;
using MGP.Backoffice.Persistance.Data.Tables;
using MGP.Backoffice.Persistance.Interfaces;
using MGP.Backoffice.Persistence.Data.Tables;
using Microsoft.EntityFrameworkCore;

namespace MGP.Backoffice.Persistance
{
    public class AgentLeaveRepository : IAgentLeaveRepository
    {
        private readonly MyDbContext _dbContext;

        public AgentLeaveRepository(MyDbContext myDbContext)
        {
            _dbContext = myDbContext;
        }
        public async Task<AgentLeave> GetAgentLeaveByIdAsync(Guid agentLeaveId)
        {
            var user = await _dbContext.Set<AgentLeave>()
                .Where(u => u.Id == agentLeaveId)
                .AsTracking()
                .FirstOrDefaultAsync();

            return user ?? throw new NotFoundException();
        }
        public async Task<List<AgentLeave>> FindByStartDateOrEndDateAsync()
        {
            return await _dbContext.Set<AgentLeave>()
                .Where(a => a.EndDate.Date == DateTime.UtcNow.Date || a.StartDate.Date == DateTime.UtcNow.Date)
                .Include(a => a.Agent).ThenInclude(agent => agent.Area)
                .ToListAsync();
        }

        public async Task<AgentLeave> CreateAsync(AgentLeave agentLeave)
        {
            agentLeave.Id = Guid.NewGuid();
            agentLeave.CreationDate = DateTime.UtcNow;

            _dbContext.Set<AgentLeave>().Add(agentLeave);
            await _dbContext.SaveChangesAsync();

            return agentLeave;
        }

        public async Task<bool> AgentHasVacationAsync(Guid agentId, DateTime startDate, DateTime endDate)
        {
            var hasVacation = await _dbContext.Set<AgentLeave>()
                .AnyAsync(al =>
                    (
                        al.AgentId == agentId
                    ) &&
                    al.StartDate < endDate &&
                    al.EndDate > startDate
                );

            return hasVacation;
        }

        public async Task<List<AgentLeave>> AgentLeaveByAgentIdAsync(Guid agentId)
        {
            return await _dbContext.Set<AgentLeave>()
                .Where(a => a.AgentId == agentId)
                .Include(a => a.Agent)
                .ToListAsync();
        }

        public async Task<AgentLeave> UpdateAsync(AgentLeave agentLeaveToUpdate)
        {
            _dbContext.Entry(agentLeaveToUpdate).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return agentLeaveToUpdate;
        }
    }
}
