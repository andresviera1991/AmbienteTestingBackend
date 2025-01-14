using MGP.Authentication.Persistance.Data.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MGP.Authentication.Persistance.Data.Configurations
{
    public class PersonConfig : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(e => e.CreationDate)
                .HasColumnType("timestamp with time zone")
                .HasPrecision(0);

            builder.Property(e => e.ModifiedDate)
                .HasColumnType("timestamp with time zone")
                .HasPrecision(0);

            builder.Property(e => e.BirthDate)
                .HasColumnType("date");

            builder.HasIndex(p => p.DocumentNumber)
                .IsUnique();

            builder.HasOne(p => p.Address)
                .WithOne()
                .HasForeignKey<Person>(p => p.AddressId)
                .OnDelete(DeleteBehavior.Restrict);

            // Índice compuesto para FirstName y LastName
            builder.HasIndex(p => new { p.Name, p.LastName })
                .HasDatabaseName("IX_Person_FullName");
        }

    }
}
