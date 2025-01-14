using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MGP.Backoffice.Persistence.Data.Tables;

namespace MGP.Authentication.Persistance.Data.Configuration;

public class UserConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasIndex(u => u.UserName).IsUnique();
        builder.HasIndex(u => u.EmployeeNumber).IsUnique();
        builder.HasIndex(u => u.DocumentNumber).IsUnique();
        builder.HasIndex(u => u.Email).IsUnique();

        builder.ToTable("User");

        builder.Property(e => e.CreationDate).HasColumnType("timestamp with time zone").HasPrecision(0);
        builder.Property(e => e.ModifiedDate).HasColumnType("timestamp with time zone").HasPrecision(0);


    }
}
