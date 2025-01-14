using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.Persistance.Data.Tables;
using MGP.Discapacidad.Persistance;
using Microsoft.EntityFrameworkCore;
using Xunit;
using MGP.Discapacidad.CrossCutting.Enum;
namespace MGP.Discapacidad.Test.Repository;

#pragma warning disable
public class DocumentRepositoryTest
{
    private readonly DocumentRepository _repository;
    private readonly DbContextOptions<MyDbContext> _options;

    public DocumentRepositoryTest()
    {
        var databaseName = Guid.NewGuid().ToString();
        _options = new DbContextOptionsBuilder<MyDbContext>()
            .UseInMemoryDatabase(databaseName)
            .Options;

        InitializeDatabaseAsync().GetAwaiter().GetResult();
        _repository = new DocumentRepository(new MyDbContext(_options));
    }

    private async Task InitializeDatabaseAsync()
    {
        using var context = new MyDbContext(_options);
        await context.Database.EnsureDeletedAsync();
        await context.Database.EnsureCreatedAsync();
    }

    [Fact]
    public async Task AddDocumentsAsync_ShouldAddDocumentsSuccessfully()
    {
        var documents = new List<Document>
        {
            new Document { DocumentTypeId = 1, DocumentImage = "/file/image1.jpg" },
            new Document { DocumentTypeId = 2, DocumentImage = "/file/image2.jpg" }
        };

        await _repository.AddDocumentsAsync(documents);

        using var context = new MyDbContext(_options);
        var storedDocuments = await context.Set<Document>().ToListAsync();
        Assert.Equal(2, storedDocuments.Count);
        Assert.All(storedDocuments, d => Assert.Equal((int)DocumentStatusEnum.PENDING_VALIDATION, d.DocumentStatusId));
    }

    [Fact]
    public async Task GetTicketIdByDocumentIdAsync_ShouldThrowNotFound_WhenDocumentDoesNotExist()
    {
        var documentId = Guid.NewGuid();

        await Assert.ThrowsAsync<DocumentNotFoundException>(() => _repository.GetTicketIdByDocumentIdAsync(documentId));
    }

    [Fact]
    public async Task RemoveDocumentAsync_ShouldMarkDocumentAsDeleted_WhenDocumentExists()
    {
        var documentId = Guid.NewGuid();
        using (var context = new MyDbContext(_options))
        {
            context.Set<Document>().Add(new Document
            {
                Id = documentId,
                DocumentStatusId = (int)DocumentStatusEnum.PENDING_VALIDATION,
                DocumentImage = "/file/image.jpg"
            });
            await context.SaveChangesAsync();
        }

        await _repository.RemoveDocumentAsync(documentId);

        using (var context = new MyDbContext(_options))
        {
            var storedDocument = await context.Set<Document>().FindAsync(documentId);
            Assert.Equal((int)DocumentStatusEnum.DELETED, storedDocument.DocumentStatusId);
        }
    }

    [Fact]
    public async Task RemoveDocumentAsync_ShouldThrowNotFound_WhenDocumentDoesNotExist()
    {
        var documentId = Guid.NewGuid();

        await Assert.ThrowsAsync<DocumentNotFoundException>(() => _repository.RemoveDocumentAsync(documentId));
    }
}