using AutoMapper;
using MGP.Authentication.Domain.Interfaces;
using MGP.Authentication.Persistance.DTOs;
using MGP.Authentication.Persistance.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace MGP.Authentication.Domain.Services;

public class CatalogService : ICatalogService
{
    private readonly ICatalogRepository _catalogRepository;
    private readonly IMapper _mapper;

    public CatalogService(ICatalogRepository catalogRespoitory,
        IMapper mapper)
    {
        _catalogRepository = catalogRespoitory;
        _mapper = mapper;
    }

    public async Task<List<GenderData>> ListGenderAsync()
    {
        return _mapper.Map<List<GenderData>>(await _catalogRepository.ListGenderAsync());
    }

    public async Task<List<UserStatusData>> ListUserStatusAsync()
    {
        return _mapper.Map<List<UserStatusData>>(await _catalogRepository.ListUserDataAsync());
    }
}
