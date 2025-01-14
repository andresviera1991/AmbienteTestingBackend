//using AutoMapper;
//using Microsoft.EntityFrameworkCore;
//using MGP.Audit.CrossCutting.Excepciones;
//using MGP.Audit.Persistance.Data.Tables;
//using Moq;
//using Xunit;
//using MGP.Audit.CrossCutting.Enum;

//namespace MGP.Audit.Test.Repository
//{
//    public class TicketRepositoryTest
//    {
//        private readonly TicketRepository _repository;
//        private readonly DbContextOptions<MyDbContext> _options;
//        private readonly Mock<IMapper> _mapperMock;

//        public TicketRepositoryTest()
//        {
//            var databaseName = Guid.NewGuid().ToString();
//            _options = new DbContextOptionsBuilder<MyDbContext>()
//                .UseInMemoryDatabase(databaseName)
//                .Options;

//            var config = new MapperConfiguration(cfg => {
//                cfg.CreateMap<CreateTicketCudData, Ticket>()
//                    .ForMember(dest => dest.Documents, opt => opt.MapFrom(src => src.Documents));
//            });

//            _mapperMock = new Mock<IMapper>();
//            _mapperMock.Setup(m => m.Map<Ticket>(It.IsAny<CreateTicketCudData>()))
//                .Returns((CreateTicketCudData src) => new Ticket
//                {
//                    Id = Guid.NewGuid(),
//                    UserId = src.UserId,
//                    TicketCode = 1,
//                    TicketStatusId = src.TicketStatusId,
//                    TicketTypeId = src.TicketTypeId,
//                    CreationDate = DateTime.UtcNow,
//                    Documents = src.Documents.Select(d => new Document
//                    {
//                        Id = d.Id,
//                        DocumentTypeId = d.DocumentTypeId,
//                        DocumentStatusId = d.DocumentStatusId,
//                        DocumentImage = d.DocumentImage,
//                        CreationDate = DateTime.UtcNow
//                    }).ToList()
//                });

//            _mapperMock.Setup(m => m.Map<TicketCud>(It.IsAny<CreateTicketCudData>()))
//                        .Returns((CreateTicketCudData src) => new TicketCud
//                        {
//                            Id = Guid.NewGuid(),
//                            CertificateExpansionOptionsId = src.CertificateExpansionOptionsId,
//                            Certificate = src.Certificate,
//                            ExpiredCertificate = src.ExpiredCertificate,
//                            LostCertificate = src.LostCertificate,
//                            HealthInsurance = src.HealthInsurance,
//                            PaySlip = src.PaySlip,
//                            SignatureOptionId = src.SignatureOptionId,
//                            DocumentComplete = src.DocumentComplete,
//                            MedicalCommitteId = src.MedicalCommitteId,
//                            Ticket = new Ticket
//                            {
//                                Id = Guid.NewGuid(),
//                                UserId = src.UserId,
//                                TicketStatusId = src.TicketStatusId,
//                                TicketTypeId = src.TicketTypeId,
//                                CreationDate = DateTime.UtcNow,
//                                Documents = src.Documents.Select(d => new Document
//                                {
//                                    Id = Guid.NewGuid(),
//                                    DocumentTypeId = d.DocumentTypeId,
//                                    DocumentStatusId = d.DocumentStatusId,
//                                    DocumentImage = "/file/image.jpg",
//                                    CreationDate = DateTime.UtcNow
//                                }).ToList()
//                            }
//                        });

//            using (var context = new MyDbContext(_options))
//            {
//                context.Database.EnsureDeleted();
//                context.Database.EnsureCreated();
//            }

//            _repository = new TicketRepository(new MyDbContext(_options), _mapperMock.Object);
//        }

//        [Fact]
//        public async Task TicketOpenExistAsync_ShouldReturnTrue_WhenOpenTicketExists()
//        {
//            var userId = Guid.NewGuid();
//            using (var context = new MyDbContext(_options))
//            {
//                context.Set<Ticket>().Add(new Ticket { UserId = userId, TicketStatusId = (int)TicketStatusType.InProcess, TicketTypeId = (int)CrossCutting.Enum.TicketType.CUD });
//                context.SaveChanges();
//            }

//            var result = await _repository.TicketOpenExistAsync(userId);

//            Assert.True(result);
//        }

//        [Fact]
//        public async Task CreateTicketCudAsync_ShouldCreateTicketSuccessfully()
//        {
//            var ticketData = new CreateTicketCudData
//            {
//                Id = Guid.NewGuid(),
//                UserId = Guid.NewGuid(),
//                Email = "usuario@ejemplo.com",
//                TicketCode = "TC123456",
//                TicketStatusId = 1,
//                TicketTypeId = 1,
//                Certificate = true,
//                ExpiredCertificate = false,
//                CertificateExpansionOptionsId = 1,
//                LostCertificate = false,
//                HealthInsurance = true,
//                PaySlip = true,
//                SignatureOptionId = 1,
//                DocumentComplete = true,
//                MedicalCommitteId = Guid.NewGuid(),
//                Documents = new List<DocumentData>
//                {
//                    new DocumentData
//                    {
//                        Id = Guid.NewGuid(),
//                        DocumentTypeId = 1,
//                        DocumentStatusId = 1,
//                        DocumentImage = "/file/image.jpg"
//                    }
//                }
//            };

//            Ticket createdTicket;
//            using (var context = new MyDbContext(_options))
//            {
//                var repository = new TicketRepository(context, _mapperMock.Object);
//                createdTicket = await repository.CreateTicketCudAsync(ticketData);
//            }

//            using (var context = new MyDbContext(_options))
//            {
//                var storedTicket = await context.Set<Ticket>().FindAsync(createdTicket.Id);
//                Assert.NotNull(storedTicket);
//                Assert.Equal(ticketData.UserId, storedTicket.UserId);
//            }
//        }

//        [Fact]
//        public async Task GetTicketCudAsync_ShouldReturnTicketCud_WhenExists()
//        {
//            var userId = Guid.NewGuid();
//            var ticketCudId = Guid.NewGuid();
//            Ticket ticket;

//            using (var context = new MyDbContext(_options))
//            {
//                ticket = await _repository.CreateTicketCudAsync(new CreateTicketCudData
//                {
//                    Id = ticketCudId,
//                    UserId = userId,
//                    Email = "usuario@ejemplo.com",
//                    TicketCode = "TC123456",
//                    TicketStatusId = 1,
//                    TicketTypeId = 1,
//                    Certificate = true,
//                    ExpiredCertificate = false,
//                    CertificateExpansionOptionsId = 1,
//                    LostCertificate = false,
//                    HealthInsurance = true,
//                    PaySlip = true,
//                    SignatureOptionId = 1,
//                    DocumentComplete = true,
//                    MedicalCommitteId = Guid.NewGuid(),
//                    Documents = new List<DocumentData>
//                    {
//                        new DocumentData
//                        {
//                            Id = Guid.NewGuid(),
//                            DocumentTypeId = 1,
//                            DocumentStatusId = 1,
//                            DocumentImage = "/file/image.jpg"
//                        }
//                    }
//                });
//            }

//            var result = await _repository.GetTicketCudAsync(ticket.Id, userId);

//            Assert.NotNull(result);
//        }

//        [Fact]
//        public async Task GetTicketCudAsync_ShouldThrowNotFound_WhenTicketDoesNotExist()
//        {
//            var userId = Guid.NewGuid();
//            var ticketId = Guid.NewGuid();

//            await Assert.ThrowsAsync<NotFoundException>(() => _repository.GetTicketCudAsync(ticketId, userId));
//        }

//        [Fact]
//        public async Task ListTicketsAsync_ShouldReturnAllUserTickets()
//        {
//            var userId = Guid.NewGuid();

//            using (var context = new MyDbContext(_options))
//            {
//                await _repository.CreateTicketCudAsync(new CreateTicketCudData
//                {
//                    Id = Guid.NewGuid(),
//                    UserId = userId,
//                    Email = "usuario@ejemplo.com",
//                    TicketCode = "TC123456",
//                    TicketStatusId = 1,
//                    TicketTypeId = 1,
//                    Certificate = true,
//                    ExpiredCertificate = false,
//                    CertificateExpansionOptionsId = 1,
//                    LostCertificate = false,
//                    HealthInsurance = true,
//                    PaySlip = true,
//                    SignatureOptionId = 1,
//                    DocumentComplete = true,
//                    MedicalCommitteId = Guid.NewGuid(),
//                    Documents = new List<DocumentData>
//                    {
//                        new DocumentData
//                        {
//                            Id = Guid.NewGuid(),
//                            DocumentTypeId = 1,
//                            DocumentStatusId = 1,
//                            DocumentImage = "/file/image.jpg"
//                        }
//                    }
//                });

//                await _repository.CreateTicketCudAsync(new CreateTicketCudData
//                {
//                    Id = Guid.NewGuid(),
//                    UserId = userId,
//                    Email = "usuario@ejemplo.com",
//                    TicketCode = "TC123456",
//                    TicketStatusId = 1,
//                    TicketTypeId = 1,
//                    Certificate = true,
//                    ExpiredCertificate = false,
//                    CertificateExpansionOptionsId = 1,
//                    LostCertificate = false,
//                    HealthInsurance = true,
//                    PaySlip = true,
//                    SignatureOptionId = 1,
//                    DocumentComplete = true,
//                    MedicalCommitteId = Guid.NewGuid(),
//                    Documents = new List<DocumentData>
//                    {
//                        new DocumentData
//                        {
//                            Id = Guid.NewGuid(),
//                            DocumentTypeId = 1,
//                            DocumentStatusId = 1,
//                            DocumentImage = "/file/image.jpg"
//                        }
//                    }
//                });
//            }

//            var result = await _repository.ListTicketsAsync(userId);

//            Assert.Equal(2, result.Length);
//        }

//        [Fact]
//        public async Task UpdateAllTicketStatusesAsync_ShouldUpdateStatusesSuccessfully()
//        {
//            var userId = Guid.NewGuid();

//            using (var context = new MyDbContext(_options))
//            {
//                context.Set<Ticket>().AddRange(new[]
//                {
//                    new Ticket { UserId = userId, TicketStatusId = (int)TicketStatusType.InProcess },
//                    new Ticket { UserId = userId, TicketStatusId = (int)TicketStatusType.InProcess }
//                });
//                await context.SaveChangesAsync();
//            }

//            await _repository.UpdateAllTicketStatusesAsync(userId, (int)TicketStatusType.Closed);

//            using (var context = new MyDbContext(_options))
//            {
//                var updatedTickets = await context.Set<Ticket>().Where(t => t.UserId == userId).ToListAsync();
//                Assert.All(updatedTickets, t => Assert.Equal((int)TicketStatusType.Closed, t.TicketStatusId));
//            }
//        }

//        [Fact]
//        public async Task VerifyUserAsync_ShouldReturnTrue_WhenUserIsOwnerOfTicket()
//        {
//            var userId = Guid.NewGuid();
//            var ticketId = Guid.NewGuid();

//            using (var context = new MyDbContext(_options))
//            {
//                context.Set<Ticket>().Add(new Ticket { Id = ticketId, UserId = userId });
//                await context.SaveChangesAsync();
//            }

//            var result = await _repository.VerifyUserAsync(userId, ticketId);

//            Assert.True(result);
//        }
//    }
//}