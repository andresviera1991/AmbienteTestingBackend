namespace MGP.Backoffice.Persistance.DTOs
{
    public class ChangePasswordData
    {
        public Guid AgentId { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
