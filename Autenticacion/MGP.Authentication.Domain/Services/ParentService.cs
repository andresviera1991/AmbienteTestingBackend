using AutoMapper;
using MGP.Authentication.Domain.Interfaces;
using MGP.Authentication.Persistance.Data.Tables;
using MGP.Authentication.Persistance.DTOs;
using MGP.Authentication.Persistance.Interface;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace MGP.Authentication.Domain.Services
{
    public class ParentService : IParentService
    {
        private readonly IParentRepository _parentRepository;
        private readonly IMapper _mapper;

        public ParentService(ILogger<ParentService> logger, IParentRepository parentRepository, IMapper mapper, IAuditService auditService)
        {
            _parentRepository = parentRepository;
            _mapper = mapper;
        }

        public async Task<Guid> AddAsync(ParentData parentData)
        {
            var userRegistered = await _parentRepository.AddAsync(_mapper.Map<Parent>(parentData));

            return userRegistered.Id;
        }
    }
}
