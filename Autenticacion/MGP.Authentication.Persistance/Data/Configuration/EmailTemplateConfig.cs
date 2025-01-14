using MGP.Authentication.Persistance.Data.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MGP.Authentication.Persistance.Data.Configurations;
public class EmailTemplateConfig : IEntityTypeConfiguration<EmailTemplate>
{
    public void Configure(EntityTypeBuilder<EmailTemplate> builder)
    {
        builder.Property(e => e.CreationDate).HasColumnType("timestamp with time zone").HasPrecision(0);
        builder.Property(e => e.ModifiedDate).HasColumnType("timestamp with time zone").HasPrecision(0);
    }
}
