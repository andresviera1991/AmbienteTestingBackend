using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.Persistance;
using MGP.Discapacidad.Persistance.Data.Tables;
using MGP.Discapacidad.Persistance.DTOs.Ticket;
using Moq;
using Xunit;
using MGP.Discapacidad.CrossCutting.Enum;
using MGP.Discapacidad.Persistance.DTOs.Document;

namespace MGP.Discapacidad.Test.Repository
{
#pragma warning disable
    public class TicketRepositoryTest
    {
        private readonly TicketRepository _repository;
        private readonly DbContextOptions<MyDbContext> _options;
        private readonly Mock<IMapper> _mapperMock;

        public TicketRepositoryTest()
        {
            var databaseName = Guid.NewGuid().ToString();
            _options = new DbContextOptionsBuilder<MyDbContext>()
                .UseInMemoryDatabase(databaseName)
                .Options;

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CreateTicketCudData, Ticket>()
                    .ForMember(dest => dest.Documents, opt => opt.MapFrom(src => src.Documents));
            });

            _mapperMock = new Mock<IMapper>();
            _mapperMock.Setup(m => m.Map<Ticket>(It.IsAny<CreateTicketCudData>()))
                .Returns((CreateTicketCudData src) => new Ticket
                {
                    Id = Guid.NewGuid(),
                    UserId = src.UserId,
                    TicketCode = "DS-DIS-039",
                    TicketStatusId = src.TicketStatusId,
                    TicketTypeId = src.TicketTypeId,
                    CreationDate = DateTime.UtcNow,
                    Documents = src.Documents.Select(d => new Document
                    {
                        Id = d.Id,
                        DocumentTypeId = d.DocumentTypeId,
                        DocumentStatusId = d.DocumentStatusId,
                        DocumentImage = d.DocumentImage,
                        CreationDate = DateTime.UtcNow
                    }).ToList()
                });

            _mapperMock.Setup(m => m.Map<TicketCud>(It.IsAny<CreateTicketCudData>()))
                        .Returns((CreateTicketCudData src) => new TicketCud
                        {
                            Id = Guid.NewGuid(),
                            CertificateExpansionOptionsId = src.CertificateExpansionOptionsId,
                            Certificate = src.Certificate,
                            ExpiredCertificate = src.ExpiredCertificate,
                            LostCertificate = src.LostCertificate,
                            HealthInsurance = src.HealthInsurance,
                            PaySlip = src.PaySlip,
                            SignatureOptionId = src.SignatureOptionId,
                            DocumentComplete = src.DocumentComplete,
                            MedicalCommitteDate = src.MedicalCommitteDate,
                            Ticket = new Ticket
                            {
                                Id = Guid.NewGuid(),
                                UserId = src.UserId,
                                TicketStatusId = src.TicketStatusId,
                                TicketTypeId = src.TicketTypeId,
                                CreationDate = DateTime.UtcNow,
                                Documents = src.Documents.Select(d => new Document
                                {
                                    Id = Guid.NewGuid(),
                                    DocumentTypeId = d.DocumentTypeId,
                                    DocumentStatusId = d.DocumentStatusId,
                                    DocumentImage = "/file/image.jpg",
                                    CreationDate = DateTime.UtcNow
                                }).ToList()
                            }
                        });

            using (var context = new MyDbContext(_options))
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }

            _repository = new TicketRepository(new MyDbContext(_options), _mapperMock.Object);
        }

        [Fact]
        public async Task TicketOpenExistAsync_ShouldReturnTrue_WhenOpenTicketExists()
        {
            var userId = Guid.NewGuid();
            var ticketCode = "DS-DIS-001";
            using (var context = new MyDbContext(_options))
            {
                context.Set<Ticket>().Add(new Ticket 
                { 
                    UserId = userId, 
                    TicketStatusId = (int)TicketStatusEnum.NEW, 
                    TicketTypeId = (int)TicketTypeEnum.CUD,
                    TicketCode = ticketCode
                });

                await context.SaveChangesAsync();
            }

            var result = await _repository.TicketOpenExistAsync(userId, TicketTypeEnum.CUD);

            Assert.True(result);
        }

        [Fact]
        public async Task CreateTicketCudAsync_ShouldCreateTicketSuccessfully()
        {
            var ticketData = new CreateTicketCudData
            {
                Id = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                Email = "usuario@ejemplo.com",
                TicketCode = "TC123456",
                TicketStatusId = 1,
                TicketTypeId = 1,
                Certificate = true,
                ExpiredCertificate = false,
                CertificateExpansionOptionsId = 1,
                LostCertificate = false,
                HealthInsurance = true,
                PaySlip = true,
                SignatureOptionId = 1,
                DocumentComplete = true,
                Documents = new List<DocumentData>
                {
                    new DocumentData
                    {
                        Id = Guid.NewGuid(),
                        DocumentTypeId = 1,
                        DocumentStatusId = 1,
                        DocumentImage = "/file/image.jpg"
                    }
                }
            };

            Ticket createdTicket;
            using (var context = new MyDbContext(_options))
            {
                var repository = new TicketRepository(context, _mapperMock.Object);
                createdTicket = await repository.CreateTicketCudAsync(ticketData);
            }

            using (var context = new MyDbContext(_options))
            {
                var storedTicket = await context.Set<Ticket>().FindAsync(createdTicket.Id);
                Assert.NotNull(storedTicket);
                Assert.Equal(ticketData.UserId, storedTicket.UserId);
            }
        }

        [Fact]
        public async Task GetTicketCudAsync_ShouldReturnTicketCud_WhenExists()
        {
            var userId = Guid.NewGuid();
            var ticketCudId = Guid.NewGuid();
            Ticket ticket;

            using (var context = new MyDbContext(_options))
            {
                ticket = await _repository.CreateTicketCudAsync(new CreateTicketCudData
                {
                    Id = ticketCudId,
                    UserId = userId,
                    Email = "usuario@ejemplo.com",
                    TicketCode = "TC123456",
                    TicketStatusId = 1,
                    TicketTypeId = 1,
                    Certificate = true,
                    ExpiredCertificate = false,
                    CertificateExpansionOptionsId = 1,
                    LostCertificate = false,
                    HealthInsurance = true,
                    PaySlip = true,
                    SignatureOptionId = 1,
                    DocumentComplete = true,
                    Documents = new List<DocumentData>
                    {
                        new DocumentData
                        {
                            Id = Guid.NewGuid(),
                            DocumentTypeId = 1,
                            DocumentStatusId = 1,
                            DocumentImage = "/file/image.jpg"
                        }
                    }
                });
            }

            var result = await _repository.GetTicketCudUserAsync(userId, ticket.Id, "DS-DIS-039");

            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetTicketCudAsync_ShouldThrowNotFound_WhenTicketDoesNotExist()
        {
            var userId = Guid.NewGuid();
            var ticketId = Guid.NewGuid();

            await Assert.ThrowsAsync<TicketNotFoundException>(() => _repository.GetTicketCudUserAsync(userId, ticketId, "DS-DIS-039"));
        }

        [Fact]
        public async Task ListTicketsAsync_ShouldReturnAllUserTickets()
        {
            var userId = Guid.NewGuid();

            using (var context = new MyDbContext(_options))
            {
                await _repository.CreateTicketCudAsync(new CreateTicketCudData
                {
                    Id = Guid.NewGuid(),
                    UserId = userId,
                    Email = "usuario@ejemplo.com",
                    TicketCode = "TC123456",
                    TicketStatusId = 1,
                    TicketTypeId = 1,
                    Certificate = true,
                    ExpiredCertificate = false,
                    CertificateExpansionOptionsId = 1,
                    LostCertificate = false,
                    HealthInsurance = true,
                    PaySlip = true,
                    SignatureOptionId = 1,
                    DocumentComplete = true,
                    Documents = new List<DocumentData>
                    {
                        new DocumentData
                        {
                            Id = Guid.NewGuid(),
                            DocumentTypeId = 1,
                            DocumentStatusId = 1,
                            DocumentImage = "/file/image.jpg"
                        }
                    }
                });

                await _repository.CreateTicketCudAsync(new CreateTicketCudData
                {
                    Id = Guid.NewGuid(),
                    UserId = userId,
                    Email = "usuario@ejemplo.com",
                    TicketCode = "TC123456",
                    TicketStatusId = 1,
                    TicketTypeId = 1,
                    Certificate = true,
                    ExpiredCertificate = false,
                    CertificateExpansionOptionsId = 1,
                    LostCertificate = false,
                    HealthInsurance = true,
                    PaySlip = true,
                    SignatureOptionId = 1,
                    DocumentComplete = true,
                    Documents = new List<DocumentData>
                    {
                        new DocumentData
                        {
                            Id = Guid.NewGuid(),
                            DocumentTypeId = 1,
                            DocumentStatusId = 1,
                            DocumentImage = "/file/image.jpg"
                        }
                    }
                });
            }

            var result = await _repository.ListTicketsAsync(userId);

            Assert.Equal(2, result.Length);
        }

        [Fact]
        public async Task UpdateAllTicketStatusesAsync_ShouldUpdateStatusesSuccessfully()
        {
            var userId = Guid.NewGuid();
            var ticketCode = "DS-DIS-001";

            using (var context = new MyDbContext(_options))
            {
                context.Set<Ticket>().AddRange(new[]
                {
                    new Ticket { UserId = userId, TicketStatusId = (int)TicketStatusEnum.IN_PROCESS_NEIGHBOR, TicketCode = ticketCode },
                    new Ticket { UserId = userId, TicketStatusId = (int)TicketStatusEnum.IN_PROCESS_NEIGHBOR, TicketCode = ticketCode }
                });
                await context.SaveChangesAsync();
            }

            await _repository.UpdateAllTicketStatusesAsync(userId, (int)TicketStatusEnum.CLOSED_DENIED);

            using (var context = new MyDbContext(_options))
            {
                var updatedTickets = await context.Set<Ticket>().Where(t => t.UserId == userId).ToListAsync();

                Assert.All(updatedTickets, t => Assert.Equal((int)TicketStatusEnum.CLOSED_DENIED, t.TicketStatusId));
            }
        }

        [Fact]
        public async Task VerifyUserAsync_ShouldReturnTrue_WhenUserIsOwnerOfTicket()
        {
            var userId = Guid.NewGuid();
            var ticketId = Guid.NewGuid();
            var ticketCode = "DS-DIS-001";

            using (var context = new MyDbContext(_options))
            {
                context.Set<Ticket>().Add(new Ticket { Id = ticketId, UserId = userId, TicketCode = ticketCode });
                await context.SaveChangesAsync();
            }

            var result = await _repository.VerifyUserAsync(userId, ticketId);

            Assert.True(result);
        }
    }
}