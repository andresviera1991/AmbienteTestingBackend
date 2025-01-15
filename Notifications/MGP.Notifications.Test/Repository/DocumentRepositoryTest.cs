//using MGP.Notifications.CrossCutting.Enum;
//using MGP.Notifications.CrossCutting.Excepciones;
//using MGP.Notifications.Persistance.Data.Tables;
//using Microsoft.EntityFrameworkCore;
//using Xunit;

//namespace MGP.Notifications.Test.Repository
//{
//    public class DocumentRepositoryTest
//    {
//        private readonly DocumentRepository _repository;
//        private readonly DbContextOptions<MyDbContext> _options;

//        public DocumentRepositoryTest()
//        {
//            var databaseName = Guid.NewGuid().ToString();
//            _options = new DbContextOptionsBuilder<MyDbContext>()
//                .UseInMemoryDatabase(databaseName)
//                .Options;

//            InitializeDatabaseAsync().GetAwaiter().GetResult();
//            _repository = new DocumentRepository(new MyDbContext(_options));
//        }

//        private async Task InitializeDatabaseAsync()
//        {
//            using (var context = new MyDbContext(_options))
//            {
//                await context.Database.EnsureDeletedAsync();
//                await context.Database.EnsureCreatedAsync();
//            }
//        }

//        [Fact]
//        public async Task AddDocumentsAsync_ShouldAddDocumentsSuccessfully()
//        {
//            var documents = new List<Document>
//            {
//                new Document { DocumentTypeId = 1, DocumentImage = "/file/image1.jpg" },
//                new Document { DocumentTypeId = 2, DocumentImage = "/file/image2.jpg" }
//            };

//            await _repository.AddDocumentsAsync(documents);

//            using (var context = new MyDbContext(_options))
//            {
//                var storedDocuments = await context.Set<Document>().ToListAsync();
//                Assert.Equal(2, storedDocuments.Count);
//                Assert.All(storedDocuments, d => Assert.Equal((int)DocumentStatusType.PendingValidation, d.DocumentStatusId));
//            }
//        }

//        [Fact]
//        public async Task GetTicketIdByDocumentIdAsync_ShouldThrowNotFound_WhenDocumentDoesNotExist()
//        {
//            var documentId = Guid.NewGuid();

//            await Assert.ThrowsAsync<NotFoundException>(() => _repository.GetTicketIdByDocumentIdAsync(documentId));
//        }

//        [Fact]
//        public async Task RemoveDocumentAsync_ShouldMarkDocumentAsDeleted_WhenDocumentExists()
//        {
//            var documentId = Guid.NewGuid();
//            using (var context = new MyDbContext(_options))
//            {
//                context.Set<Document>().Add(new Document
//                {
//                    Id = documentId,
//                    DocumentStatusId = (int)DocumentStatusType.PendingValidation,
//                    DocumentImage = "/file/image.jpg"
//                });
//                await context.SaveChangesAsync();
//            }

//            await _repository.RemoveDocumentAsync(documentId);

//            using (var context = new MyDbContext(_options))
//            {
//                var storedDocument = await context.Set<Document>().FindAsync(documentId);
//                Assert.Equal((int)DocumentStatusType.Deleted, storedDocument.DocumentStatusId);
//            }
//        }

//        [Fact]
//        public async Task RemoveDocumentAsync_ShouldThrowNotFound_WhenDocumentDoesNotExist()
//        {
//            var documentId = Guid.NewGuid();

//            await Assert.ThrowsAsync<NotFoundException>(() => _repository.RemoveDocumentAsync(documentId));
//        }
//    }
//}