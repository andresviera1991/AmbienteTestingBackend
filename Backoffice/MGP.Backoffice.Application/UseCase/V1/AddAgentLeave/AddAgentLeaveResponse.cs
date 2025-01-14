namespace MGP.Backoffice.Application.UseCase.V1.AddAgentLeave
{
    public class AddAgentLeaveResponse
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid AgentId { get; set; }
    }
}
