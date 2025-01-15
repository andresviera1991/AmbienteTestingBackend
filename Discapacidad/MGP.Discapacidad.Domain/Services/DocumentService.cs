using AutoMapper;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.Domain.interfaces;
using MGP.Discapacidad.Persistance.Data.Tables;
using MGP.Discapacidad.Persistance.DTOs.Document;
using MGP.Discapacidad.Persistance.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MGP.Discapacidad.Domain.Services;

public class DocumentService : IDocumentService
{

    private readonly IDocumentRepository _documentRepository;
    private readonly ICatalogRepository _catalogRepository;
    private readonly ITicketRepository _ticketRepository;
    private readonly IMapper _mapper;

    public DocumentService(IDocumentRepository DocumentTypeRepository,
                           IMapper mapper,
                           ITicketRepository ticketRepository,
                           ICatalogRepository catalogRepository)
    {
        _documentRepository = DocumentTypeRepository;
        _ticketRepository = ticketRepository;
        _mapper = mapper;
        _catalogRepository = catalogRepository;
    }

    #region ADD DOCUMENT

    public async Task<List<DocumentData>> AddDocumentAsync(List<DocumentData> documentData, Guid? userId, Guid ticketId)
    {

        if (userId != null && !await _ticketRepository.VerifyUserAsync((Guid)userId, ticketId))
        {
            throw new TicketNotFoundException();
        }

        documentData = await UploadImageAsync(documentData);
        documentData.ForEach(doc => doc.TicketId = ticketId);
        return _mapper.Map<List<DocumentData>>(await _documentRepository.AddDocumentsAsync(_mapper.Map<List<Document>>(documentData)));
    }
    public async Task<List<DocumentData>> UploadImageAsync(List<DocumentData> documents)
    {
        try
        {
            await VerifyDocumentTypes(documents);

            foreach (var document in documents)
            {
                string base64Content = document.DocumentImage;

                if (string.IsNullOrEmpty(document.DocumentImage))
                {
                    throw new DocumentUploadException();
                }

                string extension = string.Empty;

                if (base64Content.StartsWith("data:image/") || base64Content.StartsWith("data:application/pdf"))
                {
                    var parts = base64Content.Split(',');
                    extension = parts[0].Split(';')[0].Split('/')[1];
                    base64Content = parts[1];

                    if (!IsBase64String(base64Content))
                    {
                        throw new DocumentUploadException();
                    }
                }
                else
                {
                    throw new DocumentUploadException();
                }

                base64Content = base64Content.Trim().Replace(" ", "+");

                var stringBuilder = new StringBuilder(base64Content);
                while (stringBuilder.Length % 4 != 0)
                {
                    stringBuilder.Append('=');
                }

                base64Content = stringBuilder.ToString();

                var fileBytes = Convert.FromBase64String(base64Content);

                if (fileBytes.Length > 10 * 1024 * 1024)
                {
                    throw new DocumentUploadException();
                }

                string fileName = $"{Guid.NewGuid().ToString("N")}{DateTime.Now:yyyyMMdd}.{extension}";

                string folderPath = Path.Combine("../", "files");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string filePath = Path.Combine(folderPath, fileName);
                await File.WriteAllBytesAsync(filePath, fileBytes);

                document.DocumentImage = filePath.Replace("\\", "/");
            }
            return documents;
        }
        catch(Exception E)
        {
            throw new DocumentUploadException();
        }
    }

    #endregion

    #region REMOVE DOCUMENT
    public async Task RemoveDocumentAsync(Guid documentId, Guid userId)
    {
        Guid ticketId = await _documentRepository.GetTicketIdByDocumentIdAsync(documentId);

        if (!await _ticketRepository.VerifyUserAsync(userId, ticketId))
        {
            throw new TicketNotFoundException();
        }
        await _documentRepository.RemoveDocumentAsync(documentId);
    }

    #endregion

    #region ADD TEMPLATE

    public async Task<Guid> AddTemplateAsync(AddTemplateData addTemplateData)
    {
        bool existsTemplate = await _documentRepository.ExistsTemplateAsync(addTemplateData.Name);
        bool existsTicketType = await _ticketRepository.TicketTypeExistsAsync(addTemplateData.TicketTypeId);

        if (!existsTicketType)
        {
            throw new TicketTypeNotFoundException();
        }

        if (!existsTemplate)
        {
            var path = await UploadPDFTemplate(addTemplateData.DocumentPDF);
            var template = _mapper.Map<DocumentTemplate>(addTemplateData);
            template.DocumentPath = path;
            return await _documentRepository.AddTemplateAsync(template);
        }

        throw new TemplateDocumentAlreadyExistsException();

    }
    public static async Task<string> UploadPDFTemplate(string DocumentPDF)
    {
        string base64Content = DocumentPDF;
        base64Content = CleanBase64String(base64Content);
        byte[] fileBytes;

        try
        {
            fileBytes = Convert.FromBase64String(base64Content);
        }
        catch (FormatException)
        {
            throw new DocumentUploadException();
        }

        if (fileBytes.Length > 10 * 1024 * 1024)
        {
            throw new DocumentUploadException();
        }

        string fileName = $"{Guid.NewGuid():N}_{DateTime.Now:yyyyMMddHHmmss}.pdf";
        string folderPath = Path.Combine("../", "templates");
        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }

        string filePath = Path.Combine(folderPath, fileName);
        await File.WriteAllBytesAsync(filePath, fileBytes);

        return filePath.Replace("\\", "/");
    }
    private static string CleanBase64String(string base64Content)
    {
        if (base64Content.StartsWith("data:application/pdf;base64,"))
        {
            base64Content = base64Content["data:application/pdf;base64,".Length..];
        }

        base64Content = base64Content.Trim().Replace(" ", "+");

        while (base64Content.Length % 4 != 0)
        {
            base64Content += "=";
        }

        return base64Content;
    }
    #endregion

    #region UPDATE TEMPLATE
    public async Task UpdateTemplateAsync(UpdateTemplateData updateTemplateData)
    {
        bool existsTicketType = await _ticketRepository.TicketTypeExistsAsync(updateTemplateData.TicketTypeId);

        if (!existsTicketType)
        {
            throw new TicketTypeNotFoundException();
        }

        await _documentRepository.UpdateTemplateAsync(_mapper.Map<DocumentTemplate>(updateTemplateData));
    }

    #endregion

    #region LIST TEMPLATES

    public async Task<List<ListTemplateData>> ListTemplatesAsync(int? ticketTypeId)
    {
        return _mapper.Map<List<ListTemplateData>>(await _documentRepository.ListTemplatesAsync(ticketTypeId));
    }
    #endregion

    #region REMOVE TEMPLATE

    public async Task RemoveTemplateAsync(Guid id)
    {
        await _documentRepository.RemoveTemplateAsync(id);
    }

    #endregion

    #region PRIVATE METHODS
    private async Task VerifyDocumentTypes(List<DocumentData> documents)
    {
        var documentsTypes = documents.Select(d => d.DocumentTypeId).ToList();
        var documentTypesBD = (await _catalogRepository.ListDocumentTypesAsync()).Select(d => d.Id);

        bool allExist = documentsTypes.All(dt => documentTypesBD.Contains(dt));

        if (!allExist) { throw new DocumentTypeNotFoundException(); }
    }
    private static bool IsBase64String(string base64)
    {
        if (string.IsNullOrEmpty(base64) || base64.Length % 4 != 0)
            return false;

        return base64.All(c => "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/=".Contains(c) || c == '=');
    }

    #endregion

}
