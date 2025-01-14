using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MGP.Backoffice.Persistance.Data.Tables;

namespace MGP.Backoffice.Persistance.Data.Configuration
{
    public class AgentTicketTypeConfig : IEntityTypeConfiguration<AgentTicketType>
    {
        public void Configure(EntityTypeBuilder<AgentTicketType> builder)
        {
            builder.ToTable("AgentTicketType");

            builder.Property(e => e.CreationDate).HasColumnType("timestamp with time zone").HasPrecision(0);
            builder.Property(e => e.ModifiedDate).HasColumnType("timestamp with time zone").HasPrecision(0);
        }
    }
}