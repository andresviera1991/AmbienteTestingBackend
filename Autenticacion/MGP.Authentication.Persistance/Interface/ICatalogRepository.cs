using MGP.Authentication.Persistance.Data.Tables;
using MGP.Authentication.Persistance.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace MGP.Authentication.Persistance.Interface;

public interface ICatalogRepository
{
    public Task<List<Gender>> ListGenderAsync();
    public Task<List<UserData>> ListUserDataAsync();
}
