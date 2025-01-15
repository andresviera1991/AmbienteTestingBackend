using MGP.Notifications.Persistance.Data.Tables;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MGP.Notifications.Persistance.Interface
{
    public interface INotificationsRepository
    {
        Task<Notification> CreateNotificationsAsync(Data.Tables.Notification Notifications);
        Task<List<Data.Tables.Notification>> ListNotificationsAsync();
    }
}
