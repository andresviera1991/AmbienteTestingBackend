using MGP.Discapacidad.Persistance.DTOs;
using System.Threading.Tasks;
namespace MGP.Discapacidad.Domain.interfaces;

public interface INotificationService
{
    Task SendNotification(NotificationData notificationData);
}
