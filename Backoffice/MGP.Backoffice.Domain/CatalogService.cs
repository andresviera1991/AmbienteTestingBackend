using AutoMapper;
using MGP.Backoffice.Domain.DTOs;
using MGP.Backoffice.Domain.Interface;
using MGP.Backoffice.Persistance.DTOs;

namespace MGP.Backoffice.Domain;

public class CatalogService : ICatalogService
{
    private readonly IMapper _mapper;
    private readonly ICatalogRepository _catalogRepository;

    public CatalogService(IMapper mapper,
                          ICatalogRepository catalogRepository)
    {
        _mapper = mapper;
        _catalogRepository = catalogRepository;
    }

    public async Task<List<AreaData>> GetAreasAsync()
    {
        return _mapper.Map<List<AreaData>>(await _catalogRepository.GetAreas());
    }

    public async Task<List<RoleData>> GetRolesAsync()
    {
        return _mapper.Map<List<RoleData>>(await _catalogRepository.GetRoles());
    }
    public async Task<List<TicketTypeData>> GetTicketByAreaAsync(string area)
    {
        return _mapper.Map<List<TicketTypeData>>(await _catalogRepository.GetTicketByAreaAsync(area));
    }

    public async Task<List<UserStatusData>> ListUserStatusAsync()
    {
        return _mapper.Map<List<UserStatusData>>(await _catalogRepository.ListUserStatusAsync());
    }
}
