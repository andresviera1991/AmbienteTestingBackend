using MGP.Discapacidad.Client.DTOs.Response;
using MGP.Discapacidad.Client.Interface.Authentication;
using System.Threading.Tasks;
using System;
namespace MGP.Discapacidad.Client;

public class AuthenticationClient : IAuthenticationClient
{
    private readonly IAuthenticationApi _authenticationApi;

    public AuthenticationClient(IAuthenticationApi authenticationApi)
    {
        _authenticationApi = authenticationApi;
    }

    public async Task<UserData> GetUserDataAsync(Guid userId)
    {
        try
        {
            var getUserResponseModel = await _authenticationApi.GetUserData(userId);

            if (getUserResponseModel.Content.Data != null)
            {
                getUserResponseModel.Content.Data.Person.UserEmail = getUserResponseModel.Content.Data.Email;
                return getUserResponseModel.Content.Data;
            }
            return null;
        }
        catch (Exception)
        {
            return null;
        }

    }
}
