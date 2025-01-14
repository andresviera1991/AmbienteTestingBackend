using System;

namespace MGP.Audit.Persistance.DTOs.Audit

{
    public class AuditData
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Action { get; set; }
        public DateTime Timestamp { get; set; }
        public string EntityType { get; set; }
        public string EntityId { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string MicroserviceName { get; set; }
    }
}
