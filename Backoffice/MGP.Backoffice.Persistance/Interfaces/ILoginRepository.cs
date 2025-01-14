namespace MGP.Backoffice.Persistance.Interfaces
{
    public interface ILoginRepository
    {
        public Task RevokeRefreshSessionTokenAsync(string refreshToken, Guid agentId, DateTime expirationDate);
    }
}
