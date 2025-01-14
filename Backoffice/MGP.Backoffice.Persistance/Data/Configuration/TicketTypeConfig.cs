using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MGP.Backoffice.Persistance.Data.Tables;

namespace MGP.Backoffice.Persistance.Data.Configuration
{
    public class TicketTypeConfig : IEntityTypeConfiguration<TicketType>
    {
        public void Configure(EntityTypeBuilder<TicketType> builder)
        {
            builder.ToTable("TicketType");

            builder.Property(e => e.CreationDate).HasColumnType("timestamp with time zone").HasPrecision(0);
            builder.Property(e => e.ModifiedDate).HasColumnType("timestamp with time zone").HasPrecision(0);
        }
    }
}