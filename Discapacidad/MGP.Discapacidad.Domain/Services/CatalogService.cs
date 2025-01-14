using AutoMapper;
using MGP.Discapacidad.Domain.interfaces;
using MGP.Discapacidad.Persistance.DTOs.Catalog;
using MGP.Discapacidad.Persistance.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace MGP.Discapacidad.Domain.Services;

public class CatalogService : ICatalogService
{
    private readonly ICatalogRepository _catalogRepository;
    private readonly IMapper _mapper;

    public CatalogService(ICatalogRepository catalogRepository, IMapper mapper)
    {
        _mapper = mapper;
        _catalogRepository = catalogRepository;
    }

    public async Task<List<CardPickupLocationsOptionsData>> ListCardPickupLocationsOptionsAsync()
    {
        return _mapper.Map<List<CardPickupLocationsOptionsData>>(await _catalogRepository.ListCardPickupLocationOptionsAsync());
    }

    public async Task<List<CertificateExpansionOptionsData>> ListCertificateExpansionOptionsAsync()
    {
        return _mapper.Map<List<CertificateExpansionOptionsData>>(await _catalogRepository.ListCertificateExpansionOptionsAsync());
    }

    public async Task<List<DocumentTypeData>> ListDocumentTypeAsync()
    {
        return _mapper.Map<List<DocumentTypeData>>(await _catalogRepository.ListDocumentTypesAsync());

    }

    public async Task<List<SignatureOptionsData>> ListSignatureOptionsAsync()
    {
        return _mapper.Map<List<SignatureOptionsData>>(await _catalogRepository.ListSignatureOptionsAsync());
    }

    public async Task<List<TicketStatusData>> ListTicketStatusAsync()
    {
        return _mapper.Map<List<TicketStatusData>>(await _catalogRepository.ListTicketStatusAsync());
    }

    public async Task<List<TicketTypeData>> ListTicketTypeAsync()
    {
        return _mapper.Map<List<TicketTypeData>>(await _catalogRepository.ListTicketTypesAsync());
    }
}