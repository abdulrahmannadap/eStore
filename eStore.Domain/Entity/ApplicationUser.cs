using Microsoft.AspNetCore.Identity;

namespace eStore.Domain.Entity
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
