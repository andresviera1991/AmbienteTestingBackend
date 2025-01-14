using MGP.Backoffice.Domain.Interface;
using Quartz;

namespace MGP.Backoffice.Application.UseCase.V1.AgentVacationScheduledTask
{
    public class AgentVacationJob : IJob
    {
        private readonly IUserService _agentService;

        public AgentVacationJob(IUserService agentService)
        {
            _agentService = agentService;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            await _agentService.AssignTicketsToUsersFromLeaveAsync();
        }
    }
}
