using Microsoft.AspNetCore.SignalR;
using AutoMapper;
using MGP.Notifications.Domain.interfaces;
using MGP.Notifications.Persistance.DTOs.Notifications;
using MGP.Notifications.Persistance.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;
using MGP.Notifications.Domain.HUB;
using System.Net.Sockets;
using System.Text.Json;

namespace MGP.Notifications.Domain.Services
{
    public class NotificationsService : INotificationsService
    {
        private readonly INotificationsRepository _NotificationsRepository;
        private readonly IMapper _mapper;
        private readonly IHubContext<NotificationHub> _hubContext;

        public NotificationsService(INotificationsRepository NotificationsRepository, IMapper mapper, IHubContext<NotificationHub> hubContext)
        {
            _mapper = mapper;
            _NotificationsRepository = NotificationsRepository;
            _hubContext = hubContext;
        }

        public async Task CreateNotificationsAsync(NotificationData NotificationsData)
        {
            var notification = await _NotificationsRepository.CreateNotificationsAsync(_mapper.Map<Persistance.Data.Tables.Notification>(NotificationsData));
            string message = JsonSerializer.Serialize(notification);
            await _hubContext.Clients.All.SendAsync("ReceiveNotification", message);
        }

        public async Task<List<NotificationData>> ListNotificationsAsync()
        {
            return _mapper.Map<List<NotificationData>>(await _NotificationsRepository.ListNotificationsAsync());
        }
    }
}