using MGP.Discapacidad.Client.DTOs.Response;
using System;
using System.Threading.Tasks;
namespace MGP.Discapacidad.Client.Interface.Authentication;

public interface IAuthenticationClient
{
    public Task<UserData> GetUserDataAsync(Guid userId);
}
