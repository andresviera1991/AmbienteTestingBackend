using MGP.Discapacidad.Persistance.Data.Tables;
using MGP.Discapacidad.Persistance.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace MGP.Discapacidad.Persistance;
public class CatalogRepository : ICatalogRepository
{
    private readonly MyDbContext _dbContext;

    public CatalogRepository(MyDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<CertificateExpansionOptions>> ListCertificateExpansionOptionsAsync()
    {
        return await _dbContext.Set<CertificateExpansionOptions>().ToListAsync();
    }

    public async Task<List<TicketStatus>> ListTicketStatusAsync()
    { 
        return await _dbContext.Set<TicketStatus>().ToListAsync();
    }


    public async Task<List<DocumentType>> ListDocumentTypesAsync()
    {
        return await _dbContext.Set<DocumentType>().ToListAsync();
    }

    public async Task<List<SignatureOption>> ListSignatureOptionsAsync()
    {
        return await _dbContext.Set<SignatureOption>().ToListAsync();
    }

    public async Task<List<TicketType>> ListTicketTypesAsync()
    {
        return await _dbContext.Set<TicketType>().ToListAsync();
    }

    public async Task<List<CardPickupLocationsOptions>> ListCardPickupLocationOptionsAsync()
    {
        return await _dbContext.Set<CardPickupLocationsOptions>().ToListAsync();
    }
}