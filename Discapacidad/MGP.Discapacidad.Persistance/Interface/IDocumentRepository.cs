using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MGP.Discapacidad.Persistance.Data.Tables;
namespace MGP.Discapacidad.Persistance.Interface;

public interface IDocumentRepository
{
    Task<List<Document>> AddDocumentsAsync(List<Document> documents);
    Task<Guid> AddTemplateAsync(DocumentTemplate documentTemplate);
    Task<bool> ExistsTemplateAsync(string name);
    Task<List<DocumentTemplate>> ListTemplatesAsync(int? ticketTypeId);
    Task<Guid> GetTicketIdByDocumentIdAsync(Guid documentId);
    Task RemoveDocumentAsync(Guid documentId);
    Task RemoveTemplateAsync(Guid id);
    Task UpdateTemplateAsync(DocumentTemplate updateTemplate);
}
