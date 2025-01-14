using System;
namespace MGP.Backoffice.Api.Controllers.Agent.Request;

public class UpdateAgentLeaveRequestModel
{
    public Guid? Id { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}
