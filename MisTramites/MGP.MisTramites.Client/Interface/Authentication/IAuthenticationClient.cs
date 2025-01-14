namespace MGP.MisTramites.Client.Interface.Authentication;

public interface IAuthenticationClient
{
    public Task<List<Guid>> ListUserIdsByFiltersAsync(string fullName, string documentNumber);

}
