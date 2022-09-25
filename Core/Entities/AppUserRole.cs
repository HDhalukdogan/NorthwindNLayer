using Microsoft.AspNetCore.Identity;

namespace Core.Entities
{
    public class AppUserRole : IdentityUserRole<string>
    {
        public AppUser AppUser { get; set; }
        public AppRole AppRole { get; set; }
    }
}
