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
    public class LoginRepository : ILoginRepository
    {
        private readonly MyDbContext _dbContext;

        public LoginRepository(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> GetUserByUserIdAsync(Guid userId)
        {
            User user = await _dbContext.Set<User>().Where(u => u.Id == userId).
                                               Include(u => u.Person).
                                               FirstOrDefaultAsync() ?? throw new NotFoundException();

            return user;
        }

        public async Task<User> GetUserByUserNameAsync(string userName)
        {
            return await _dbContext.Set<User>().Where(u => u.UserName.Equals(userName)).
                                               FirstOrDefaultAsync() ?? throw new NotFoundException();
        }

        public async Task IncrementFailedLoginsAsync(User user)
        {
            user.FailedLoginAttempts++;

            if (user.FailedLoginAttempts >= 3)
            {
                user.UserStatusId = (int)UserStatusType.USER_DISABLED;
                await _dbContext.SaveChangesAsync();
                throw new UserDisabledException();
            }

            await _dbContext.SaveChangesAsync();
        }

        public async Task ResetFailedLoginAsync(User user)
        {
            user.FailedLoginAttempts = 0;
            await _dbContext.SaveChangesAsync();
        }

        public async Task RevokeRefreshSessionTokenAsync(string refreshToken, Guid userId, DateTime expirationDate)
        {
            bool exists = await _dbContext.Set<RevokedRefreshToken>().AnyAsync(u => u.RefreshToken == refreshToken);

            if (exists)
            {
                throw new InvalidRefreshTokenException();
            }
            RevokedRefreshToken refreshTokens = new()
            {
                Id = Guid.NewGuid(),
                RefreshToken = refreshToken,
                UserId = userId,
                ExpirationDate = expirationDate,
                CreationDate = DateTime.UtcNow      
            };

            _dbContext.Set<RevokedRefreshToken>().Add(refreshTokens);
            await _dbContext.SaveChangesAsync();
        }
    }
}
