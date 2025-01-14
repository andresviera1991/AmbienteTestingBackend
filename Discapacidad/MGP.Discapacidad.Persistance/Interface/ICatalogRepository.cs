using MGP.Discapacidad.Persistance.Data.Tables;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace MGP.Discapacidad.Persistance.Interface;

public interface ICatalogRepository
{
    Task<List<CardPickupLocationsOptions>> ListCardPickupLocationOptionsAsync();
    Task<List<CertificateExpansionOptions>> ListCertificateExpansionOptionsAsync();
    Task<List<DocumentType>> ListDocumentTypesAsync();
    Task<List<SignatureOption>> ListSignatureOptionsAsync();
    Task<List<TicketStatus>> ListTicketStatusAsync();
    Task<List<TicketType>> ListTicketTypesAsync();
}
