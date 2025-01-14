using MGP.Backoffice.Persistence.Data.Tables;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MGP.Backoffice.Persistance.Data.Seeds
{
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = Guid.Parse("ab76bc84-45e2-4ce5-bcc5-9d6a5aa4e21b"),
                    EmployeeNumber = "123456",
                    FirstName = "admin",
                    LastName = "admin",
                    DocumentNumber = "44413552",
                    UserStatusId = 1,
                    AreaId = null,
                    CreationDate = DateTime.UtcNow,
                    ModifiedDate = null,
                    QueuePosition = 0,
                    UserName = "44413552",
                    NormalizedUserName = "44413552",
                    Email = "cristian.fernandez@avalith.net",
                    NormalizedEmail = "CRISTIAN.FERNANDEZ@AVALITH.NET",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAIAAYagAAAAECaxMkXFEcpSvk45sqf5io8dB1O8858sxcYP2ISQR2MfUcxLdeJf4wlEebFyvspT9A==",
                    SecurityStamp = "6df4f47c-f703-4764-bdff-81a3d2c021d0",
                    ConcurrencyStamp = null,
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = false,
                    AccessFailedCount = 0
                },
                new User
                {
                    Id = Guid.Parse("18d14490-91c1-4ba6-843c-9b501d187049"),
                    EmployeeNumber = "882536",
                    FirstName = "John",
                    LastName = "Supervisor",
                    DocumentNumber = "41139455",
                    UserStatusId = 1,
                    AreaId = 1,
                    CreationDate = DateTime.UtcNow,
                    ModifiedDate = null,
                    QueuePosition = 0,
                    UserName = "41139455",
                    NormalizedUserName = "41139455",
                    Email = "cristian.fer.mel@gmail.com",
                    NormalizedEmail = "CRISTIAN.FER.MEL@GMAIL.COM",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAIAAYagAAAAECaxMkXFEcpSvk45sqf5io8dB1O8858sxcYP2ISQR2MfUcxLdeJf4wlEebFyvspT9A==",
                    SecurityStamp = "XWDC3VQU5TCMCIJBNHECVHJYLL3OTI34",
                    ConcurrencyStamp = "d837d926-6935-4a9c-8ab9-9d8edd1f5dcf",
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = false,
                    AccessFailedCount = 0
                },
                new User
                {
                    Id = Guid.Parse("18d14490-91c1-4ba6-843c-9b501d187050"),
                    EmployeeNumber = "882537",
                    FirstName = "John",
                    LastName = "Agente Uno",
                    DocumentNumber = "17027227",
                    UserStatusId = 1,
                    AreaId = 1,
                    CreationDate = DateTime.UtcNow,
                    ModifiedDate = null,
                    QueuePosition = 0,
                    UserName = "17027227",
                    NormalizedUserName = "17027227",
                    Email = "c.fernandez.melian@hotmail.com",
                    NormalizedEmail = "c.fernandez.melian@hotmail.com",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAIAAYagAAAAECaxMkXFEcpSvk45sqf5io8dB1O8858sxcYP2ISQR2MfUcxLdeJf4wlEebFyvspT9A==",
                    SecurityStamp = "XWDC3VQU5TCMCIJBNHECVHJYLL3OTI34",
                    ConcurrencyStamp = "d837d926-6935-4a9c-8ab9-9d8edd1f5dcf",
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = false,
                    AccessFailedCount = 0
                },
                new User
                {
                    Id = Guid.Parse("18d14490-91c1-4ba6-843c-9b501d187051"),
                    EmployeeNumber = "882538",
                    FirstName = "John",
                    LastName = "Agente Dos",
                    DocumentNumber = "21004652",
                    UserStatusId = 1,
                    AreaId = 1,
                    CreationDate = DateTime.UtcNow,
                    ModifiedDate = null,
                    QueuePosition = 0,
                    UserName = "21004652",
                    NormalizedUserName = "21004652",
                    Email = "leandro.gomez.pae@gmail.com",
                    NormalizedEmail = "leandro.gomez.pae@gmail.com",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAIAAYagAAAAECaxMkXFEcpSvk45sqf5io8dB1O8858sxcYP2ISQR2MfUcxLdeJf4wlEebFyvspT9A==",
                    SecurityStamp = "XWDC3VQU5TCMCIJBNHECVHJYLL3OTI34",
                    ConcurrencyStamp = "d837d926-6935-4a9c-8ab9-9d8edd1f5dcf",
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = false,
                    AccessFailedCount = 0
                }
            );
        }
    }
}