using MGP.Authentication.Persistance.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MGP.Authentication.Domain.Interfaces;

public interface IUserService
{
    Task<UserData> GetUserByIdAsync(Guid id);
    Task<UserData> GetUserByUserNameAsync(string userName);
    Task<Guid> RegisterAsync(UserData user);
    Task ValidateUserAsync(string token);
    Task<UserData> PatchUserAsync(UserDataToUpdate userToUpdate);
    Task DeleteUserAsync(Guid id);
    Task<List<Guid>> ListUserIdsByFilterAsync(string fullName, string documentNumber);
    Task<Guid> RegisterByAgentAsync(UserData userData);
    Task<List<ResumeUserData>> ListUsersByFilterAsync(string fullName, string documentNumber, int pageSize, int pageNumber);
}
