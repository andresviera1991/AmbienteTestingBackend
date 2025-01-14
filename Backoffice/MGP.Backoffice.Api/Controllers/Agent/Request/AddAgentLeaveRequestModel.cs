using System;

namespace MGP.Backoffice.Api.Controllers.Agent.Request
{
    public class AddAgentLeaveRequestModel
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
