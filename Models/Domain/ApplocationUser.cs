
using Microsoft.AspNetCore.Identity;

namespace Katalog.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
