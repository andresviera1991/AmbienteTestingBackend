using MGP.Discapacidad.Persistance.Data.Tables;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
namespace MGP.Discapacidad.Persistance.Data.Seeds;
public class CardPickupLocationsOptionsSeed : IEntityTypeConfiguration<CardPickupLocationsOptions>
{
    public void Configure(EntityTypeBuilder<CardPickupLocationsOptions> builder)
    {
        builder.HasData(
            new CardPickupLocationsOptions
            {
                Id = 1,
                Name = "Delegación Puerto - AYOLAS 3670",
                CreationDate = DateTime.UtcNow

            },
            new CardPickupLocationsOptions
            {
                Id = 2,
                Name = "Sede Discapacidad - Pescadores 567",
                CreationDate = DateTime.UtcNow

            },
            new CardPickupLocationsOptions
            {
                Id = 3,
                Name = "Delegación Sierra de Los Padres - Padre Luis Varetto 251",
                CreationDate = DateTime.UtcNow
            }
        );

    }
}
