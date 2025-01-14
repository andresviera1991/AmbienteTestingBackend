using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGP.Audit.Persistance.Data.Tables
{
    [Table("Audit")]
    public partial class Audit
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        [MaxLength(256)]
        public string Action { get; set; }

        [Required]
        public DateTime Timestamp { get; set; }

        [Required]
        [MaxLength(256)]
        public string EntityType { get; set; }

        [Required]
        public string EntityId { get; set; }

        [MaxLength(2000)]
        public string OldValue { get; set; }

        [MaxLength(2000)]
        public string NewValue { get; set; }

        [Required]
        [MaxLength(256)]
        public string MicroserviceName { get; set; }
    }
}
