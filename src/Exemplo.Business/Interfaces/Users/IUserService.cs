using Exemplo.Business.Models;

namespace Exemplo.Business.Interfaces
{
    public interface IUserService
    {
        Task<ApplicationUser> GetByIdWithPerson(Guid id);
        Task<bool> Add(ApplicationUser user, string password);
        Task<bool> Update(ApplicationUser user);
        Task<bool> Update(ApplicationUser user, string password);
    }
}
