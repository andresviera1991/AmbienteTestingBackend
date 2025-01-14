using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MGP.Backoffice.Persistance.Data.Tables;

namespace MGP.Backoffice.Persistance.Data.Configuration;

public class MenuByAreaAndRoleConfig : IEntityTypeConfiguration<MenuByAreaAndRole>
{
    public void Configure(EntityTypeBuilder<MenuByAreaAndRole> builder)
    {
        builder.ToTable("MenuByAreaAndRole");

        builder.HasKey(m => new { m.RoleId, m.MenuId, m.AreaId });

        builder.Property(e => e.CreationDate)
               .HasColumnType("timestamp with time zone")
               .HasPrecision(0);

        builder.Property(e => e.ModifiedDate)
               .HasColumnType("timestamp with time zone")
               .HasPrecision(0);
    }
}
