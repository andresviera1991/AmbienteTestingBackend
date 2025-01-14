using MGP.Discapacidad.Persistance.DTOs.Catalog;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace MGP.Discapacidad.Domain.interfaces;

public interface ICatalogService
{
    Task<List<CardPickupLocationsOptionsData>> ListCardPickupLocationsOptionsAsync();
    Task<List<CertificateExpansionOptionsData>> ListCertificateExpansionOptionsAsync();
    Task<List<DocumentTypeData>> ListDocumentTypeAsync();
    Task<List<SignatureOptionsData>> ListSignatureOptionsAsync();
    Task<List<TicketStatusData>> ListTicketStatusAsync();
    Task<List<TicketTypeData>> ListTicketTypeAsync();

}
