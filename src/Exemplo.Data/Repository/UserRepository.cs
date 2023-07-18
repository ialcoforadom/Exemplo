using Exemplo.Business.Interfaces;
using Exemplo.Business.Models;
using Exemplo.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Exemplo.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ExemploDbContext Db;
        protected readonly DbSet<ApplicationUser> DbSet;

        public UserRepository(ExemploDbContext db)
        {
            Db = db;
            DbSet = db.Set<ApplicationUser>();
        }

        public async Task<ApplicationUser> GetByIdWithPerson(Guid id)
        {
            return await Db.ApplicationUsers.AsNoTracking()
                .Include(c => c.PhysicalPerson)
                .Include(c => c.JuridicalPerson)
                .SingleOrDefaultAsync(c => c.Id == id);
        }
    }
}
