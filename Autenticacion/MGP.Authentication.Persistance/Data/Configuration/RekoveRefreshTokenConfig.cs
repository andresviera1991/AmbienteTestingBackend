﻿using MGP.Authentication.Persistance.Data.Tables;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MGP.Authentication.Persistance.Data.Configuration
{
    public class RevokeRefreshTokenConfig : IEntityTypeConfiguration<RevokedRefreshToken>
    {
        public void Configure(EntityTypeBuilder<RevokedRefreshToken> builder)
        {
            builder.HasIndex(rt => rt.RefreshToken);
            builder.Property(e => e.CreationDate).HasColumnType("timestamp with time zone").HasPrecision(0);
            builder.Property(e => e.ModifiedDate).HasColumnType("timestamp with time zone").HasPrecision(0);

        }
    }
}
