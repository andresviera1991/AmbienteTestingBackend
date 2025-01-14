using MGP.Discapacidad.Persistance.Data.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
namespace MGP.Discapacidad.Persistance.Data.Seeds;
public class SignatureOptionsSeed : IEntityTypeConfiguration<SignatureOption>
{
    public void Configure(EntityTypeBuilder<SignatureOption> builder)
    {
        builder.HasData(
                        new SignatureOption
                        {
                            Id = 1,
                            Name = "Firma realizada por la persona misma",
                            CreationDate = DateTime.UtcNow
                        },
                        new SignatureOption
                        {
                            Id = 2,
                            Name = "Firma realizada conjuntamente con otra persona",
                            CreationDate = DateTime.UtcNow
                        },
                        new SignatureOption
                        {
                            Id = 3,
                            Name = "Firma realizada por un tercero",
                            CreationDate = DateTime.UtcNow
                        }
        );
    }
}
