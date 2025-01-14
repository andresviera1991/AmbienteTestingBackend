using MGP.Audit.Persistance.Data.Tables;
using MGP.Audit.Persistance.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MGP.Audit.Persistance
{
    public class AuditRepository : IAuditRepository
    {
        private readonly MyDbContext _dbContext;

        public AuditRepository(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAuditAsync(Data.Tables.Audit audit)
        {
            audit.Id = Guid.NewGuid();
            await _dbContext.AddAsync(audit);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Data.Tables.Audit>> ListAuditAsync()
        {
            return await _dbContext.Set<Data.Tables.Audit>().ToListAsync();
        }
    }
}