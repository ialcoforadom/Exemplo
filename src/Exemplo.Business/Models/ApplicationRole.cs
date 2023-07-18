using Microsoft.AspNetCore.Identity;

namespace Exemplo.Business.Models
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public ICollection<ApplicationUserRole> UserRoles { get; set; }

        public ApplicationRole(string name) : base(name) { }
    }
}
