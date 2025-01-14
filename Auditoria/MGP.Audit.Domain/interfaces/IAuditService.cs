using MGP.Audit.Persistance.DTOs.Audit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MGP.Audit.Domain.interfaces
{
    public interface IAuditService
    {
        Task CreateAuditAsync(AuditData auditData);
        Task<List<AuditData>> ListAuditAsync();

    }
}
