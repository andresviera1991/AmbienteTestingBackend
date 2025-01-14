using System.Collections.Generic;

namespace MGP.Discapacidad.Client.DTOs.Response;
public class GetAgentResponseModel
{
    public List<string> Message { get; set; }
    public int Code { get; set; }
    public AgentData Data { get; set; }
}
