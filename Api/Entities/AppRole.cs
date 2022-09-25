using Microsoft.AspNetCore.Identity;

namespace Api.Entities
{
    public class AppRole : IdentityRole
    {
        public ICollection<AppUserRole> AppUserRoles { get; set; }
    }
}
