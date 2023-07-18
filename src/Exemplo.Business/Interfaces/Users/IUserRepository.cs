using Exemplo.Business.Models;

namespace Exemplo.Business.Interfaces
{
    public interface IUserRepository
    {
        Task<ApplicationUser> GetByIdWithPerson(Guid id);
    }
}
