using MGP.Authentication.Persistance.DTOs;
using System;
using System.Threading.Tasks;

namespace MGP.Authentication.Domain.Interfaces
{
    public interface IAuditService
    {
        Task SendAudit(AuditData auditData);
        Task DeleteTickets(Guid id);
    }
}
