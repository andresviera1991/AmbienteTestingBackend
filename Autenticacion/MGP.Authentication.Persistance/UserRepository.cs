using MGP.Authentication.Persistance.Interface;
using MGP.Authentication.Persistance.Data.Tables;
using System.Linq;
using MGP.Authentication.CrossCutting.Exceptions;
using System;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using MGP.Authentication.Persistance.Data.Enum;
using System.Collections.Generic;
namespace MGP.Authentication.Persistance;
public class UserRepository : IUserRepository
{
    private readonly MyDbContext _dbcontext;

    public UserRepository(MyDbContext dbContext)
    {
        _dbcontext = dbContext;
    }

    public async Task<User> GetUserByUserNameAsync(string userName)
    {
        return await _dbcontext.Set<User>().Where(u => u.UserName == userName).SingleOrDefaultAsync() ?? throw new NotFoundException();
    }

    public async Task<User> RegisterAsync(User user, bool returnExistingUserId = false)
    {
        var existUser = await _dbcontext.Set<User>()
            .Where(u => u.Person.DocumentNumber == user.Person.DocumentNumber)
            .SingleOrDefaultAsync();

        if (existUser == null)
        {
            user.Id = Guid.NewGuid();
            user.UserName = user.Person.DocumentNumber;
            user.UserStatusId = (int)UserStatusType.USER_INACTIVE;
            user.PersonId = Guid.NewGuid();
            user.LevelId = (int)UserLevelType.LEVEL_ZERO;
            user.CreationDate = DateTime.UtcNow;
            user.Person.Id = user.PersonId;
            user.Person.CreationDate = DateTime.UtcNow;

            if (string.IsNullOrEmpty(user.Email))
            {
                user.Email = "";
            }

            if (user.Person.PhoneNumber != null)
            {
                user.Person.PhoneNumber.Id = Guid.NewGuid();
                user.Person.PhoneNumber.CreationDate = DateTime.UtcNow;
            }

            if (user.Person.Address != null)
            {
                user.Person.Address.Id = Guid.NewGuid();
                user.Person.Address.CreationDate = DateTime.UtcNow;
            }


            await _dbcontext.AddAsync(user);
            await _dbcontext.SaveChangesAsync();
            return user;
        }

        if (returnExistingUserId)
        {
            throw new UserAlreadyException(existUser.Id);
        }
        throw new UserAlreadyException();
    }

    public async Task ValidateUserAsync(Guid userId)
    {
        User user = await _dbcontext.Set<User>().Where(u => u.Id == userId).SingleOrDefaultAsync() ?? throw new NotFoundException();
        user.UserStatusId = (int)UserStatusType.USER_ACTIVE;
        await _dbcontext.SaveChangesAsync();
    }

    public async Task<User> GetUserByIdAsync(Guid userId)
    {
        var user = await _dbcontext.Set<User>()
            .Include(u => u.Person)
                .ThenInclude(p => p.Address)
            .Include(u => u.Person)
                .ThenInclude(p => p.PhoneNumber)
            .Where(u => u.Id == userId)
            .AsTracking()
            .FirstOrDefaultAsync();

        return user ?? throw new NotFoundException();
    }

    public async Task<Parent> GetParentByPersonId(Guid personId)
    {
        Parent parent = await _dbcontext.Set<Parent>()
            .Where(p => p.PersonId == personId)
            .Select(p => new Parent
            {
                Id = p.Id,
                Name = p.Name,
                LastName = p.LastName,
                DocumentNumber = p.DocumentNumber,
                PersonId = p.PersonId,
            })
            .SingleOrDefaultAsync();

        return parent;
    }

    public async Task<User> UpdateAsync(User userToUpdate)
    {
        var user = await _dbcontext.Set<User>().Where(u => u.Person.DocumentNumber == userToUpdate.Person.DocumentNumber).SingleOrDefaultAsync();

        if (user == null || user.Id == userToUpdate.Id)
        {
            _dbcontext.Entry(userToUpdate).State = EntityState.Modified;
            await _dbcontext.SaveChangesAsync();
            return userToUpdate;
        }
        throw new DocumentNumberException();

    }

    public async Task<List<Guid>> ListUserIdsByFilterAsync(string fullName, string documentNumber)
    {
        IQueryable<User> query = _dbcontext.Set<User>().Include(u => u.Person);

        query = FilterByFullName(fullName, query);
        query = FilterByDocumentNumber(documentNumber, query);

        return await query.Select(u => u.Id).ToListAsync();
    }

    public async Task<List<User>> ListUsersByFilterAsync(string fullName, string documentNumber, int pageSize, int pageNumber)
    {
        IQueryable<User> query = _dbcontext.Set<User>().Include(u => u.Person).Include(u => u.UserStatus);

        query = FilterByFullName(fullName, query);
        query = FilterByDocumentNumber(documentNumber, query);

        query = query.Skip((pageNumber - 1) * pageSize).Take(pageSize);

        return await query.ToListAsync();

    }

    private static IQueryable<User> FilterByDocumentNumber(string documentNumber, IQueryable<User> query)
    {
        if (!string.IsNullOrWhiteSpace(documentNumber))
        {
            query = query.Where(u => u.Person.DocumentNumber.Contains(documentNumber));
        }

        return query;
    }

    private static IQueryable<User> FilterByFullName(string fullName, IQueryable<User> query)
    {
        if (!string.IsNullOrWhiteSpace(fullName))
        {
            var fullNameParts = fullName.ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var part in fullNameParts)
            {
                query = query.Where(u =>
                    u.Person.Name.ToLower().Contains(part) ||
                    u.Person.LastName.ToLower().Contains(part)
                );
            }
        }

        return query;
    }

    public async Task UpdateParentToPerson(Parent parentToUpdate, Guid personId)
    {
        var parent = await _dbcontext.Set<Parent>().Where(p => p.PersonId == personId).FirstOrDefaultAsync();

        if (parent != null)
        {
            parent.DocumentNumber = parentToUpdate.DocumentNumber;
            parent.LastName = parentToUpdate.LastName;
            parent.Name = parentToUpdate.Name;
            parent.ModifiedDate = UtcDateTime();
        }
        else
        {
            Parent newParent = new()
            {
                CreationDate = DateTime.UtcNow,
                Id = Guid.NewGuid(),
                LastName = parentToUpdate.LastName,
                Name = parentToUpdate.Name,
                DocumentNumber = parentToUpdate.DocumentNumber,
                PersonId = personId
            };

            _dbcontext.Add(newParent);
        }
    }

    private static DateTime UtcDateTime()
    {
        DateTime adjustedUtcNow = DateTime.UtcNow.AddHours(-3);
        return DateTime.SpecifyKind(adjustedUtcNow, DateTimeKind.Utc);
    }

}
