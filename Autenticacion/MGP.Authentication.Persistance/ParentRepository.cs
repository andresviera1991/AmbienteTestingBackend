using MGP.Authentication.Persistance.Interface;
using MGP.Authentication.Persistance.Data.Tables;
using System.Threading.Tasks;
using System;

namespace MGP.Authentication.Persistance
{

    public class ParentRepository : IParentRepository
    {
        private readonly MyDbContext _dbcontext;

        public ParentRepository(MyDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public async Task<Parent> AddAsync(Parent parent)
        {
            parent.CreationDate = DateTime.UtcNow;
            await _dbcontext.AddAsync(parent);
            await _dbcontext.SaveChangesAsync();
            return parent;
        }
    }
}
