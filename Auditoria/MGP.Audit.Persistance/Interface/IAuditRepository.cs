using System.Collections.Generic;
using System.Threading.Tasks;

namespace MGP.Audit.Persistance.Interface
{
    public interface IAuditRepository
    {
        Task CreateAuditAsync(Data.Tables.Audit audit);
        Task<List<Data.Tables.Audit>> ListAuditAsync();
    }
}
