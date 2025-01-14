using MGP.Discapacidad.Persistance.Data.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MGP.Discapacidad.Persistance.Data.Configurations;
public class ChatMessageConfig : IEntityTypeConfiguration<ChatMessage>
{
    public void Configure(EntityTypeBuilder<ChatMessage> builder)
    {
        builder.HasIndex(t => t.TicketId);
        builder.Property(e => e.SentAt).HasColumnType("timestamp with time zone").HasPrecision(0);
    }
}
