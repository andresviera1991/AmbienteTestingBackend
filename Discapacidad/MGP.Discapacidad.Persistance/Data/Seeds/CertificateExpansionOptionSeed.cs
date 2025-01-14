using MGP.Discapacidad.Persistance.Data.Tables;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
namespace MGP.Discapacidad.Persistance.Data.Seeds;
public class CertificateExpansionOptionSeed : IEntityTypeConfiguration<CertificateExpansionOptions>
{
    public void Configure(EntityTypeBuilder<CertificateExpansionOptions> builder)
    {
        builder.HasData(
            new CertificateExpansionOptions
            {
                Id = 1,
                Name = "No amplía",
                CreationDate = DateTime.UtcNow

            },
            new CertificateExpansionOptions
            {
                Id = 2,
                Name = "Agravamiento de Patología",
                CreationDate = DateTime.UtcNow

            },
            new CertificateExpansionOptions
            {
                Id = 3,
                Name = "Nueva Patología",
                CreationDate = DateTime.UtcNow

            }
        );

    }
}
