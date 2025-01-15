using MGP.Notifications.Persistance.DTOs.Notifications;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MGP.Notifications.Domain.interfaces
{
    public interface INotificationsService
    {
        Task CreateNotificationsAsync(NotificationData NotificationsData);
        Task<List<NotificationData>> ListNotificationsAsync();

    }
}
