namespace MGP.Backoffice.Domain.DTOs
{
    public class AgentLeaveDataToUpdate : AgentLeaveData
    {
        public new Guid? Id { get; set; }
        public new DateTime? StartDate { get; set; }
        public new DateTime? EndDate { get; set; }
    }
}
