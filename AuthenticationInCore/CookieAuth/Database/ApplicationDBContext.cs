using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CookieAuth.Database
{
    public class ApplicationDBContext : IdentityDbContext<User>
    {
        public ApplicationDBContext( DbContextOptions<ApplicationDBContext> options )
            : base( options )
        {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().Property( x => x.Fullname ).HasMaxLength(10);
            modelBuilder.HasDefaultSchema("Identity");
        }
    }
}
