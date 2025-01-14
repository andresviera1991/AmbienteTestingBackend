using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MGP.Audit.Persistance.Data.Configurations
{
    public class AuditConfig : IEntityTypeConfiguration<Tables.Audit>
    {
        public void Configure(EntityTypeBuilder<Tables.Audit> builder)
        {
            builder.HasIndex(a => a.Id).IsUnique();
            builder.HasIndex(t => t.UserId);

            builder.Property(e => e.Timestamp).HasColumnType("timestamp with time zone").HasPrecision(0);

        }
    }
}
