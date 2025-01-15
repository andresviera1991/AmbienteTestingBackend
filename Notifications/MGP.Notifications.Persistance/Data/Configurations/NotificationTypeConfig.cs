using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MGP.Notifications.Persistance.Data.Configurations
{
    public class NotificationTypeConfig : IEntityTypeConfiguration<Tables.NotificationType>
    {
        public void Configure(EntityTypeBuilder<Tables.NotificationType> builder)
        {
            builder.HasIndex(a => a.Id).IsUnique();
            builder.Property(e => e.CreationDate).HasColumnType("timestamp with time zone").HasPrecision(0);
            builder.Property(e => e.ModifiedDate).HasColumnType("timestamp with time zone").HasPrecision(0);

        }
    }
}
