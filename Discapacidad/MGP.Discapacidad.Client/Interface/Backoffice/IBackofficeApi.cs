using MGP.Discapacidad.Client.DTOs.Request;
using MGP.Discapacidad.Client.DTOs.Response;
using Refit;
using System;
using System.Threading.Tasks;
namespace MGP.Discapacidad.Client.Interface.Backoffice;

[Headers("Content-Type: application/json")]
public interface IBackofficeApi
{
    [Get("/api/v1/agent/next-available-agent")]
    Task<ApiResponse<NextAvailableAgentResponseModel>> GetNextAvailableAgent(NextAvailableAgentRequestModel request);

    [Get("/api/v1/agent/get")]
    Task<ApiResponse<GetAgentResponseModel>> GetAgentData([Header("EmployeeId")] Guid agentId);
}
