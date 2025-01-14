using MGP.Discapacidad.Persistance.Data.Tables;
using MGP.Discapacidad.Persistance;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MGP.Discapacidad.Test.Repository
{
    public class CatalogRepositoryTest
    {
        private readonly CatalogRepository _repository;
        private readonly DbContextOptions<MyDbContext> _options;

        public CatalogRepositoryTest()
        {
            _options = new DbContextOptionsBuilder<MyDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _repository = new CatalogRepository(new MyDbContext(_options));
            InitializeDatabaseAsync().GetAwaiter().GetResult();
        }

        private async Task InitializeDatabaseAsync()
        {
            using (var context = new MyDbContext(_options))
            {
                await context.Database.EnsureDeletedAsync();
                await context.Database.EnsureCreatedAsync();
            }
        }

        [Fact]
        public async Task ListCertificateExpansionOptionsAsync_ShouldReturnAllOptions()
        {
            var result = await _repository.ListCertificateExpansionOptionsAsync();
            Assert.NotNull(result);
            Assert.Equal(3, result.Count);
        }

        [Fact]
        public async Task ListTicketStatusAsync_ShouldReturnAllStatuses()
        {
            var result = await _repository.ListTicketStatusAsync();
            Assert.NotNull(result);
            Assert.Equal(8, result.Count);
        }

        [Fact]
        public async Task ListDocumentTypesAsync_ShouldReturnAllDocumentTypes()
        {
            var result = await _repository.ListDocumentTypesAsync();
            Assert.NotNull(result);
            Assert.Equal(21, result.Count);
        }

        [Fact]
        public async Task ListSignatureOptionsAsync_ShouldReturnAllSignatureOptions()
        {
            var result = await _repository.ListSignatureOptionsAsync();
            Assert.NotNull(result);
            Assert.Equal(3, result.Count);
        }

        [Fact]
        public async Task ListTicketTypesAsync_ShouldReturnAllTicketTypes()
        {
            var result = await _repository.ListTicketTypesAsync();
            Assert.NotNull(result);
            Assert.Equal(3, result.Count);
        }
    }
}