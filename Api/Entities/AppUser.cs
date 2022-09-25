using Microsoft.AspNetCore.Identity;

namespace Api.Entities
{
    public class AppUser : IdentityUser
    {
        public ICollection<AppUserRole> AppUserRoles { get; set; }
    }
}
