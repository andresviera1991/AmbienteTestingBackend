using MGP.Authentication.CrossCutting.Exceptions;
using MGP.Authentication.Persistance.Data.Enum;
using MGP.Authentication.Persistance.Data.Tables;
using MGP.Authentication.Persistance.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MGP.Authentication.Persistance
{
    public class PasswordRepository : IPasswordRepository
    {

        private readonly MyDbContext _dbcontext;

        public PasswordRepository(MyDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public async Task ResetPasswordAsync(Guid userId, string newPassword)
        {

            User user = await _dbcontext.Set<User>().Where(u => u.Id == userId).Include(u => u.Level).SingleOrDefaultAsync() ?? throw new NotFoundException();
            user.Password = newPassword;
            user.LevelId = (int)UserLevelType.LEVEL_ZERO;
            user.FailedLoginAttempts = 0;
            user.UserStatusId = (int)UserStatusType.USER_ACTIVE;
            await _dbcontext.SaveChangesAsync();
        }

        public async Task SaveChangePasswordAsync()
        {
            await _dbcontext.SaveChangesAsync();
        }

        public async Task<bool> UserExistsAsync(Guid userId)
        {

            bool exists = await _dbcontext.Set<User>().AnyAsync(u => u.Id == userId);

            if (!exists)
            {
                throw new NotFoundException();
            }
            return exists;
        }
    }
}
