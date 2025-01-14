using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MGP.Backoffice.Persistance.Data.Tables;

namespace MGP.Authentication.Persistance.Data.Configuration;

public class MenuConfig : IEntityTypeConfiguration<Menu>
{
    public void Configure(EntityTypeBuilder<Menu> builder)
    {
        builder.ToTable("Menu");

        builder.Property(e => e.CreationDate).HasColumnType("timestamp with time zone").HasPrecision(0);
        builder.Property(e => e.ModifiedDate).HasColumnType("timestamp with time zone").HasPrecision(0);

        builder.HasOne(m => m.ParentMenu)
                .WithMany(m => m.ChildMenus)
                .HasForeignKey(m => m.ParentMenuId)
                .OnDelete(DeleteBehavior.Restrict);

    }
}
