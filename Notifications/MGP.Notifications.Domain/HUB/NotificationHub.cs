using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace MGP.Notifications.Domain.HUB
{
    public class NotificationHub : Hub
    {
        private static bool _isConnected = false;

        public override async Task OnConnectedAsync()
        {
            _isConnected = true;
            string message = "Cliente conectado.";
            await SendNotification(message);
        }

        public async Task SendNotification(string message)
        {
            if (Clients != null && _isConnected)
            {
                await Clients.All.SendAsync("ReceiveNotification", message);
            }
        }
    }
}