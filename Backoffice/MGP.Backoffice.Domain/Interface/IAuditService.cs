using MGP.Backoffice.Domain.DTOs;

namespace MGP.Backoffice.Domain.Interface
{
    public interface IAuditService
    {
        Task SendAudit(AuditData auditData);
    }
}
