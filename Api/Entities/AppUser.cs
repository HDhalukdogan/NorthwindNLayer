using Microsoft.AspNetCore.Identity;

namespace Api.Entities
{
    public class AppUser : IdentityUser
    {
        public string? City { get; set; }
        public DateTime? BirthDate { get; set; }
        public ICollection<AppUserRole> AppUserRoles { get; set; }
    }
}
