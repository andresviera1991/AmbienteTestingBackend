using MGP.Notifications.Persistance.Data.Tables.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGP.Notifications.Persistance.Data.Tables
{
    [Table("Notification")]
    public partial class Notification : EntityBaseGuid
    {

        [Required]
        public Guid UserId { get; set; }

        [Required]
        [MaxLength(256)]
        public string Message { get; set; }

        [Required]
        [MaxLength(256)]
        public string URL { get; set; }

        [Required]
        public bool Read { get; set; }

        [Required]
        public int NotificationTypeId { get; set; }

        [ForeignKey("NotificationTypeId")]
        public NotificationType NotificationType { get; set; }
    }
}
