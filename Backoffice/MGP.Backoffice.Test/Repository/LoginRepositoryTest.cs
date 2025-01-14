using MGP.Backoffice.CrossCutting.Exceptions;
using MGP.Backoffice.Persistance;
using MGP.Backoffice.Persistance.Data.Tables;
using MGP.Backoffice.Persistence.Data.Tables;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MGP.Backoffice.Test.Repository
{
    public class LoginRepositoryTest
    {
        private readonly LoginRepository _repository;
        private readonly MyDbContext _dbContext;

        public LoginRepositoryTest()
        {
            var options = new DbContextOptionsBuilder<MyDbContext>()
                .UseInMemoryDatabase("TestDatabaseLogin")
                .Options;

            _dbContext = new MyDbContext(options);
            _repository = new LoginRepository(_dbContext);
            _dbContext.Database.EnsureDeleted();
            SeedTestData();
        }

        [Fact]
        public async Task RevokeRefreshSessionTokenAsync_ShouldThrowInvalidRefreshTokenException_WhenTokenExists()
        {
            var refreshToken = "existing-refresh-token";
            var agentId = Guid.NewGuid();
            var expirationDate = DateTime.UtcNow.AddDays(1);

            await Assert.ThrowsAsync<InvalidRefreshTokenException>(() =>
                _repository.RevokeRefreshSessionTokenAsync(refreshToken, agentId, expirationDate));
        }

        [Fact]
        public async Task RevokeRefreshSessionTokenAsync_ShouldAddRevokedToken_WhenTokenDoesNotExist()
        {
            var refreshToken = "new-refresh-token";
            var agentId = Guid.NewGuid();
            var expirationDate = DateTime.UtcNow.AddDays(1);

            await _repository.RevokeRefreshSessionTokenAsync(refreshToken, agentId, expirationDate);

            var revokedToken = await _dbContext.Set<RevokedRefreshSessionToken>()
                .FirstOrDefaultAsync(r => r.RefreshToken == refreshToken && r.AgentId == agentId);

            Assert.NotNull(revokedToken);
            Assert.Equal(refreshToken, revokedToken.RefreshToken);
            Assert.Equal(agentId, revokedToken.AgentId);
            Assert.Equal(expirationDate, revokedToken.ExpirationDate);
        }

        private void SeedTestData()
        {
            var revokedToken = _dbContext.Set<RevokedRefreshSessionToken>().FirstOrDefault(r => r.RefreshToken == "existing-refresh-token");
            if (revokedToken == null)
            {
                revokedToken = new RevokedRefreshSessionToken
                {
                    Id = Guid.NewGuid(),
                    RefreshToken = "existing-refresh-token",
                    AgentId = Guid.NewGuid(),
                    ExpirationDate = DateTime.UtcNow.AddDays(1),
                    CreationDate = DateTime.UtcNow
                };
                _dbContext.Set<RevokedRefreshSessionToken>().Add(revokedToken);
            }

            _dbContext.SaveChanges();
        }
    }
}