using AutoMapper;
using MGP.Backoffice.CrossCutting.Exceptions;
using MGP.Backoffice.Domain.DTOs;
using MGP.Backoffice.Domain.Interface;
using MGP.Backoffice.Persistance.Interfaces;
using MGP.Backoffice.Persistence.Data.Tables;
using Microsoft.AspNetCore.Identity;


namespace MGP.Backoffice.Domain;

public class MenuService : IMenuService
{
    private readonly IMenuRepository _menuRepository;
    private readonly IAreaRepository _areaRepository;
    private readonly RoleManager<Role> _roleManager;
    private readonly IMapper _mapper;


    public MenuService(IMenuRepository menuRepository, RoleManager<Role> roleManager, IMapper mapper, IAreaRepository areaRepository)
    {
        _menuRepository = menuRepository;
        _roleManager = roleManager;
        _mapper = mapper;
        _areaRepository = areaRepository;
    }

    public async Task<List<MenuDto>> ListMenusAsync(AreaRolData areaRolData)
    {
        var role = await _roleManager.FindByNameAsync(areaRolData.Role)
                ?? throw new RoleNotFoundException();

        if (role.Name != "ADMIN")
        {
            var area = await _areaRepository.FindByNameAsync(areaRolData.Area)
                       ?? throw new AreaNotFoundException();

            return _mapper.Map<List<MenuDto>>(await _menuRepository.ListMenusAsync(role.Id, area.Id));
        }

        return _mapper.Map<List<MenuDto>>(await _menuRepository.ListMenusAsync(role.Id));
    }
}
