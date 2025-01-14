namespace MGP.Backoffice.Domain.Models
{
    public class TokenInformation
    {
        public Guid AgentId { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
