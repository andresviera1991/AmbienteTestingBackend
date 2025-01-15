using System;

namespace MGP.Notifications.Persistance.DTOs.Notifications

{
    public class NotificationData
    {
        public Guid UserId { get; set; }
        public string Message { get; set; }
        public string URL { get; set; }
        public int NotificationTypeId { get; set; }
        public bool Read { get; set; }
    }
}
