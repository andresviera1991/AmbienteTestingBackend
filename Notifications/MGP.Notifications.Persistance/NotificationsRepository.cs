using MGP.Notifications.Persistance.Data.Tables;
using MGP.Notifications.Persistance.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MGP.Notifications.Persistance
{
    public class NotificationsRepository : INotificationsRepository
    {
        private readonly MyDbContext _dbContext;

        public NotificationsRepository(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Notification> CreateNotificationsAsync(Data.Tables.Notification notification)
        {
            notification.Id = Guid.NewGuid();
            notification.CreationDate = DateTime.UtcNow;
            await _dbContext.AddAsync(notification);
            await _dbContext.SaveChangesAsync();
            return notification;
        }

        public async Task<List<Data.Tables.Notification>> ListNotificationsAsync()
        {
            return await _dbContext.Set<Data.Tables.Notification>().ToListAsync();
        }
    }
}