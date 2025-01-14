using MGP.Discapacidad.Persistance.DTOs.Catalog;
using System;
namespace MGP.Discapacidad.Application.UseCase.V1.Document.AddDocument;
public class AddDocumentResponse
{
    public Guid Id { get; set; }
    public DocumentTypeData DocumentType { get; set; }
    public string DocumentImage { get; set; }
}
