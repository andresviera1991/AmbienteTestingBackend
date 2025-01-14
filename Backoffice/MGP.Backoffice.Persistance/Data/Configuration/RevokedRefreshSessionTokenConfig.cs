using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MGP.Backoffice.Persistance.Data.Tables;

namespace MGP.Authentication.Persistance.Data.Configuration;

public class RevokedRefreshSessionTokenConfig : IEntityTypeConfiguration<RevokedRefreshSessionToken>
{
    public void Configure(EntityTypeBuilder<RevokedRefreshSessionToken> builder)
    {
        builder.ToTable("RevokedRefreshSessionToken");

        builder.Property(e => e.CreationDate).HasColumnType("timestamp with time zone").HasPrecision(0);
        builder.Property(e => e.ModifiedDate).HasColumnType("timestamp with time zone").HasPrecision(0);
    }
}
