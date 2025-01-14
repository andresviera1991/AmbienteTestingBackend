using MGP.Discapacidad.Persistance.Data.Tables;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
namespace MGP.Discapacidad.Persistance.Data.Configurations;
public class DocumentTemplateConfig : IEntityTypeConfiguration<DocumentTemplate>
{
    public void Configure(EntityTypeBuilder<DocumentTemplate> builder)
    {
        builder.HasIndex(t => t.Name).IsUnique();

        builder.Property(e => e.CreationDate).HasColumnType("timestamp with time zone").HasPrecision(0);
        builder.Property(e => e.ModifiedDate).HasColumnType("timestamp with time zone").HasPrecision(0);

    }
}
