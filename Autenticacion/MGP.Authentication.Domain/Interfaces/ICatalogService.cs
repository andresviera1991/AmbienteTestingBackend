using MGP.Authentication.Persistance.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace MGP.Authentication.Domain.Interfaces;

public interface ICatalogService
{
    Task<List<GenderData>> ListGenderAsync();
    Task<List<UserStatusData>> ListUserStatusAsync();
}
