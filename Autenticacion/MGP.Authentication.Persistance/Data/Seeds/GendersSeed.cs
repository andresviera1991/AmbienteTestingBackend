using MGP.Authentication.Persistance.Data.Tables;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;

namespace MGP.Authentication.Persistance.Data.Seeds
{
    public class GendersSeed : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.HasData(
                new Gender
                {
                    Id = 1,
                    Description = "Masculino",
                    CreationDate = DateTime.UtcNow
                },
                new Gender
                {
                    Id = 2,
                    Description = "Femenino",
                    CreationDate = DateTime.UtcNow
                },
                new Gender
                {
                    Id = 3,
                    Description = "Otro",
                    CreationDate = DateTime.UtcNow
                }
            );
        }
    }
}
