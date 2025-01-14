using MGP.Discapacidad.Client.DTOs.Response;
using Refit;
using System;
using System.Threading.Tasks;
namespace MGP.Discapacidad.Client.Interface.Authentication;

[Headers("Content-Type: application/json")]
public interface IAuthenticationApi
{
    
    [Get("/api/v1/user/get")]
    Task<ApiResponse<GetUserResponseModel>> GetUserData([Header("UserId")] Guid userId);
}


