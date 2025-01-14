using MGP.Authentication.Persistance.Data.Tables;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MGP.Authentication.Persistance.Interface
{
    public interface IUserRepository
    {
        Task<User> GetUserByUserNameAsync(string userName);
        Task<User> RegisterAsync(User user, bool returnExistingUserId = false);
        Task ValidateUserAsync(Guid userId);
        Task<User> GetUserByIdAsync(Guid userId);
        Task<User> UpdateAsync(User userToUpdate);
        Task<List<Guid>> ListUserIdsByFilterAsync(string fullName, string documentNumber);
        Task<List<User>> ListUsersByFilterAsync(string fullName, string documentNumber, int pageSize, int pageNumber);
        Task UpdateParentToPerson(Parent parentToUpdate, Guid personId);
        Task<Parent> GetParentByPersonId(Guid personId);
    }
}
