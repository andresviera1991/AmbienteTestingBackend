using MGP.Discapacidad.CrossCutting.Enum;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.Persistance.Data.Tables;
using MGP.Discapacidad.Persistance.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace MGP.Discapacidad.Persistance;
public class DocumentRepository : IDocumentRepository
{
    private readonly MyDbContext _dbContext;

    public DocumentRepository(MyDbContext dbContext)
    {
        _dbContext = dbContext;
    }


    #region DOCUMENT METHODS
    public async Task<List<Document>> AddDocumentsAsync(List<Document> documents)
    {
        foreach (var document in documents)
        {
            document.Id = Guid.NewGuid();
            document.DocumentStatusId = (int)DocumentStatusEnum.PENDING_VALIDATION;
            document.CreationDate = DateTime.UtcNow;
            await _dbContext.AddAsync(document);
        }
        await _dbContext.SaveChangesAsync();

        return await ListNewDocuments(documents);


    }
    private async Task<List<Document>> ListNewDocuments(List<Document> documents)
    {
        var documentIds = documents.Select(d => d.Id).ToList();
        var documentsWithTypes = await _dbContext.Set<Document>()
            .Where(d => documentIds.Contains(d.Id))
            .Include(d => d.DocumentType)
            .ToListAsync();

        return documentsWithTypes;
    }
    public async Task<Guid> GetTicketIdByDocumentIdAsync(Guid documentId)
    {
        var ticketId = await _dbContext.Set<Document>()
            .Where(d => d.Id == documentId)
            .Select(d => d.TicketId)
            .FirstOrDefaultAsync();
        return ticketId != Guid.Empty ? ticketId : throw new DocumentNotFoundException();
    }
    public async Task RemoveDocumentAsync(Guid documentId)
    {
        Document document = await _dbContext.Set<Document>().Where(d => d.Id == documentId).SingleOrDefaultAsync() ?? throw new DocumentNotFoundException();
        document.DocumentStatusId = (int)DocumentStatusEnum.DELETED;
        await _dbContext.SaveChangesAsync();
    }

    #endregion

    #region TEMPLATE METHODS
    public async Task<Guid> AddTemplateAsync(DocumentTemplate documentTemplate)
    {
        DateTime adjustedUtcNow = DateTime.UtcNow.AddHours(-3);
        adjustedUtcNow = DateTime.SpecifyKind(adjustedUtcNow, DateTimeKind.Utc);

        documentTemplate.Id = Guid.NewGuid();
        documentTemplate.Status = true;
        documentTemplate.CreationDate = adjustedUtcNow;

        await _dbContext.Set<DocumentTemplate>().AddAsync(documentTemplate);
        await _dbContext.SaveChangesAsync();
        return documentTemplate.Id;

        throw new TemplateDocumentAlreadyExistsException();
    }
    public async Task<bool> ExistsTemplateAsync(string name)
    {
        return await _dbContext.Set<DocumentTemplate>().AnyAsync(d => d.Name == name);
    }
    public async Task UpdateTemplateAsync(DocumentTemplate updateTemplate)
    {
        DateTime adjustedUtcNow = DateTime.UtcNow.AddHours(-3);
        adjustedUtcNow = DateTime.SpecifyKind(adjustedUtcNow, DateTimeKind.Utc);

        var template = await _dbContext.Set<DocumentTemplate>().Where(t => t.Id == updateTemplate.Id).SingleOrDefaultAsync() ?? throw new TemplateNotFoundException();

        template.Information = updateTemplate.Information;
        template.Status = updateTemplate.Status;
        template.Name = updateTemplate.Name;
        template.TicketTypeId = updateTemplate.TicketTypeId;
        template.ModifiedDate = adjustedUtcNow;


        await _dbContext.SaveChangesAsync();
    }

    public async Task<List<DocumentTemplate>> ListTemplatesAsync(int? ticketTypeId)
    {
        IQueryable<DocumentTemplate> query = _dbContext.Set<DocumentTemplate>();

        if (ticketTypeId != null)
        {
            query = query.Where(t => t.TicketTypeId == ticketTypeId);
        }

        query = query.Where(t => t.Status);

        return await query.ToListAsync();
    }

    public async Task RemoveTemplateAsync(Guid id)
    {
        var template = await _dbContext.Set<DocumentTemplate>().Where(t => t.Id == id).SingleOrDefaultAsync() ?? throw new TemplateNotFoundException();
        _dbContext.Remove(template);
        await _dbContext.SaveChangesAsync();
    }

    #endregion

}