using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MGP.Discapacidad.Persistance.Data.Tables;
using System;
namespace MGP.Discapacidad.Persistance.Data.Seeds;
public class TicketTypeSeed : IEntityTypeConfiguration<TicketType>
{
    public void Configure(EntityTypeBuilder<TicketType> builder)
    {
        builder.HasData(
            new TicketType
            {
                Id = 1,
                Name = "CUD",
                CreationDate = DateTime.UtcNow
            },
            new TicketType
            {
                Id = 2,
                Name = "SUBE",
                CreationDate = DateTime.UtcNow
            },
            new TicketType
            {
                Id = 3,
                Name = "ESTACIONAMIENTO",
                CreationDate = DateTime.UtcNow
            }
        );
    }
}