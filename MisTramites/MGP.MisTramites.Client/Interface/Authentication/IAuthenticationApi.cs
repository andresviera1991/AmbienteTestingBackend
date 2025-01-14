using MGP.MisTramites.Client.DTOs.Request;
using MGP.MisTramites.Client.DTOs.Response.ListUserIds;
using Refit;
namespace MGP.MisTramites.Client.Interface.Authentication;

[Headers("Content-Type: application/json")]
public interface IAuthenticationApi
{

    [Get("/api/v1/user/list-ids-by-filters")]
    Task<ApiResponse<ListUserIdsByFilterResponse>> ListUserIdsByFiltersAsync([Query("request")]ListUserIdsByFilterRequestModel request);

}


