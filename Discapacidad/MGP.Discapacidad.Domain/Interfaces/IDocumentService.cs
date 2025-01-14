using MGP.Discapacidad.Persistance.DTOs.Document;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MGP.Discapacidad.Domain.interfaces;

public interface IDocumentService
{
    Task<List<DocumentData>> AddDocumentAsync(List<DocumentData> documentData, Guid? userId, Guid ticketId);
    Task<Guid> AddTemplateAsync(AddTemplateData addTemplateData);
    Task<List<ListTemplateData>> ListTemplatesAsync(int? ticketTypeId);
    Task RemoveDocumentAsync (Guid documentId, Guid userId);
    Task RemoveTemplateAsync(Guid id);
    Task UpdateTemplateAsync(UpdateTemplateData updateTemplateData);
    Task<List<DocumentData>> UploadImageAsync(List<DocumentData> documents);
}
