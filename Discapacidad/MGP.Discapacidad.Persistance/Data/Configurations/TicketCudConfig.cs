﻿using MGP.Discapacidad.Persistance.Data.Tables;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
namespace MGP.Discapacidad.Persistance.Data.Configurations;
public class TicketCudConfig : IEntityTypeConfiguration<TicketCud>
{
    public void Configure(EntityTypeBuilder<TicketCud> builder)
    {
        builder.HasKey(tc => tc.Id);

        builder.HasOne(tc => tc.Ticket)
               .WithOne()
               .HasForeignKey<TicketCud>(tc => tc.Id)
               .OnDelete(DeleteBehavior.Cascade);

        builder.Property(e => e.MedicalCommitteDate).HasColumnType("timestamp with time zone").HasPrecision(0);
        builder.Property(e => e.CreationDate).HasColumnType("timestamp with time zone").HasPrecision(0);
        builder.Property(e => e.ModifiedDate).HasColumnType("timestamp with time zone").HasPrecision(0);

    }
}
