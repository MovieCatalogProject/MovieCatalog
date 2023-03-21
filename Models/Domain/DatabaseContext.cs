using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Katalog.Models.Domain
{
    public class DatabaseContext : IdentityDbContext<ApplicationUser> //Това е клас, който представя контекста
        //на базата данни за даденото приложение.
    {
        public DatabaseContext (DbContextOptions<DatabaseContext> options) : base(options) 
        {

        }

        public DbSet<Genre> Genre { get; set; }
        public DbSet<MovieGenre> MovieGenre { get; set; }
        public DbSet<Movie> Movie { get; set; }
    }
}
