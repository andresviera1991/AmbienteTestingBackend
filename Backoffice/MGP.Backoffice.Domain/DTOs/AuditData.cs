namespace MGP.Backoffice.Domain.DTOs
{
    public class AuditData
    {
        public Guid Id { get; private set; }
        public Guid UserId { get; private set; }
        public string Action { get; private set; }
        public DateTime Timestamp { get; private set; }
        public string EntityType { get; private set; }
        public string EntityId { get; private set; }
        public string OldValue { get; private set; }
        public string NewValue { get; private set; }
        public string MicroserviceName { get; private set; }

        public AuditData(
            Guid userId,
            string action,
            string entityType,
            string entityId,
            string oldValue,
            string newValue)
        {
            UserId = userId;
            Action = action;
            Timestamp = DateTime.UtcNow;
            EntityType = entityType;
            EntityId = entityId;
            OldValue = oldValue;
            NewValue = newValue;
            MicroserviceName = "Authentcation";
        }
    }
}