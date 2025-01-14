using MGP.Discapacidad.Persistance.DTOs.Document;
using System.Collections.Generic;
namespace MGP.Discapacidad.Application.UseCase.V1.Document.ListTemplates;
public class ListTemplatesResponse
{
    public List<ListTemplateData> Templates { get; set; }
}
