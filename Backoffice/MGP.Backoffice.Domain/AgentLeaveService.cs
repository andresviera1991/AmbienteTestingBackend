using AutoMapper;
using MGP.Backoffice.CrossCutting.Exceptions;
using MGP.Backoffice.Domain.DTOs;
using MGP.Backoffice.Domain.Interface;
using MGP.Backoffice.Persistance.Data.Tables;
using MGP.Backoffice.Persistance.Interfaces;
using System.Text.Json;

namespace MGP.Backoffice.Domain
{
    public class AgentLeaveService : IAgentLeaveService
    {
        IUserService _userService;
        private readonly IAgentLeaveRepository _agentLeaveRepository;
        private readonly IMapper _mapper;

        public AgentLeaveService(
            IUserService userService,
            IAgentLeaveRepository agentLeaveRepository,
            IMapper mapper)
        {
            _userService = userService;
            _agentLeaveRepository = agentLeaveRepository;
            _mapper = mapper;
        }

        public async Task<AgentLeaveData> CreateAgentLeaveAsync(AgentLeaveData agentLeaveData)
        {
            var agent = await _userService.GetUserByIdAsync(agentLeaveData.AgentId) ?? throw new NotFoundException();

            var agentLeaveOld = await _agentLeaveRepository.AgentHasVacationAsync(agentLeaveData.AgentId, agentLeaveData.StartDate,agentLeaveData.EndDate);

            if (agentLeaveOld)
            {
                throw new AgentHasVacationException();
            }
            var agentLeave = _mapper.Map<AgentLeave>(agentLeaveData);
            agentLeave.CreationDate = DateTime.UtcNow;
            var result = await _agentLeaveRepository.CreateAsync(agentLeave);

            return _mapper.Map<AgentLeaveData>(result);
        }

        public async Task<List<AgentLeaveData>> GetAgentLeaveByAgentIdAsync(Guid agentId)
        {
            return _mapper.Map<List<AgentLeaveData>>(await _agentLeaveRepository.AgentLeaveByAgentIdAsync(agentId));
        }

        public async Task<AgentLeaveData> PatchAgentLeaveAsync(AgentLeaveDataToUpdate agentLeaveToUpdate)
        {
            AgentLeave agentLeave = await _agentLeaveRepository.GetAgentLeaveByIdAsync(agentLeaveToUpdate.Id.Value);
            agentLeaveToUpdate.Id = null;
            if (agentLeaveToUpdate == null)
            {
                throw new NotFoundException();
            }

            if (await _userService.GetUserByIdAsync(agentLeaveToUpdate.AgentId) == null)
            {
                throw new NotFoundException();
            }

            var jsonOld = JsonSerializer.Serialize(agentLeaveToUpdate);

            agentLeaveToUpdate.StartDate = agentLeaveToUpdate.StartDate != null && agentLeave.StartDate != agentLeaveToUpdate.StartDate ? agentLeaveToUpdate.StartDate : null;
            agentLeave.StartDate = agentLeaveToUpdate.StartDate != null ? agentLeaveToUpdate.StartDate.Value : agentLeave.StartDate;

            agentLeaveToUpdate.EndDate = agentLeaveToUpdate.EndDate != null && agentLeave.EndDate != agentLeaveToUpdate.EndDate ? agentLeaveToUpdate.EndDate : null;
            agentLeave.EndDate = agentLeaveToUpdate.EndDate != null ? agentLeaveToUpdate.EndDate.Value : agentLeave.EndDate;

            agentLeave.ModifiedDate = DateTime.UtcNow;
            AgentLeave agentLeaveUpdated = await _agentLeaveRepository.UpdateAsync(agentLeave);

            //await _auditService.SendAudit(new AuditData(
            //    userUpdated.Id,
            //    "PATCH",
            //    "User",
            //    userUpdated.Id.ToString(),
            //    jsonOld,
            //    JsonSerializer.Serialize(userToUpdate)
            //));

            return _mapper.Map<AgentLeaveData>(agentLeaveUpdated);
        }
    }
}
