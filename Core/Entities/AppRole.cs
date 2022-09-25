using Microsoft.AspNetCore.Identity;

namespace Core.Entities
{
    public class AppRole : IdentityRole
    {
        public ICollection<AppUserRole> AppUserRoles { get; set; }
    }
}
