using MGP.MisTramites.Client.DTOs.Request;
using MGP.MisTramites.Client.Interface.Authentication;
using MGP.MisTramites.CrossCutting.Exceptions;
namespace MGP.MisTramites.Client;

public class AuthenticationClient : IAuthenticationClient
{

    private readonly IAuthenticationApi _authenticationApi;

    public AuthenticationClient(IAuthenticationApi authenticationApi)
    {
        _authenticationApi = authenticationApi;
    }

    public async Task<List<Guid>> ListUserIdsByFiltersAsync(string fullName, string documentNumber)
    {
        try
        {
            var request = new ListUserIdsByFilterRequestModel() { DocumentNumber = documentNumber, FullName = fullName };
            var response = await _authenticationApi.ListUserIdsByFiltersAsync(request);

            if (response.IsSuccessStatusCode)
            {
                return response.Content.Data;
            }
            throw new UserNotFoundException();

        }
        catch (Exception)
        {
            throw new UserNotFoundException();
        }
    }
}
