using MGP.Backoffice.CrossCutting.Exceptions;
using MGP.Backoffice.Persistance.Data.Tables;
using MGP.Backoffice.Persistance.Interfaces;
using MGP.Backoffice.Persistence.Data.Tables;
using Microsoft.EntityFrameworkCore;

namespace MGP.Backoffice.Persistance
{
    public class LoginRepository : ILoginRepository
    {
        private readonly MyDbContext _dbContext;

        public LoginRepository(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task RevokeRefreshSessionTokenAsync(string refreshToken, Guid agentId, DateTime expirationDate)
        {
            bool exists = await _dbContext.Set<RevokedRefreshSessionToken>().AnyAsync(u => u.RefreshToken == refreshToken);

            if (exists)
            {
                throw new InvalidRefreshTokenException();
            }

            RevokedRefreshSessionToken refreshTokens = new()
            {
                Id = Guid.NewGuid(),
                RefreshToken = refreshToken,
                AgentId = agentId,
                ExpirationDate = expirationDate,
                CreationDate = DateTime.UtcNow
            };

            _dbContext.Set<RevokedRefreshSessionToken>().Add(refreshTokens);

            await _dbContext.SaveChangesAsync();
        }
    }
}
