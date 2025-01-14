using MGP.Authentication.Persistance.Data.Tables;
using System.Threading.Tasks;

namespace MGP.Authentication.Persistance.Interface
{
    public interface IParentRepository
    {
        Task<Parent> AddAsync(Parent user);
    }
}
