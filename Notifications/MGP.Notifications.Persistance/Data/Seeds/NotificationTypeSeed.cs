using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using MGP.Notifications.Persistance.Data.Tables;

namespace MGP.Authentication.Persistance.Data.Seeds
{
    public class NotificationTypeSeed : IEntityTypeConfiguration<NotificationType>
    {
        public void Configure(EntityTypeBuilder<NotificationType> builder)
        {
            builder.HasData(
                new NotificationType
                {
                    Id = 1,
                    Description = "New Message",
                    CreationDate = DateTime.UtcNow
                },
                new NotificationType
                {
                    Id = 2,
                    Description = "Update",
                    CreationDate = DateTime.UtcNow
                },
                new NotificationType
                {
                    Id = 3,
                    Description = "Mass",
                    CreationDate = DateTime.UtcNow
                }
            );
        }
    }
}
