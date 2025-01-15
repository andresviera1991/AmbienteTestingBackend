using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MGP.Notifications.Persistance.Data.Configurations
{
    public class NotificationConfig : IEntityTypeConfiguration<Tables.Notification>
    {
        public void Configure(EntityTypeBuilder<Tables.Notification> builder)
        {
            builder.HasIndex(a => a.Id).IsUnique();
            builder.HasIndex(t => t.UserId);

            builder.Property(e => e.CreationDate).HasColumnType("timestamp with time zone").HasPrecision(0);
            builder.Property(e => e.ModifiedDate).HasColumnType("timestamp with time zone").HasPrecision(0);
        }
    }
}
