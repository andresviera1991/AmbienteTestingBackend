using System;
namespace MGP.Discapacidad.Persistance.DTOs;

public class NotificationData
{
    public Guid UserId { get; set; }
    public string Message { get; set; }
    public string URL { get; set; }
    public int NotificationTypeId { get; set; }

    public NotificationData(
        Guid userId,
        string message,
        string url,
        int notificationTypeId)
    {
        UserId = userId;
        Message = message;
        URL = url;
        NotificationTypeId = notificationTypeId;
    }
}
