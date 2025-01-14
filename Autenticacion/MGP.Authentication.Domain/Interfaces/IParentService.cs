using MGP.Authentication.Persistance.DTOs;
using System;
using System.Threading.Tasks;

namespace MGP.Authentication.Domain.Interfaces
{
    public interface IParentService
    {
        Task<Guid> AddAsync(ParentData parentData);
    }
}
