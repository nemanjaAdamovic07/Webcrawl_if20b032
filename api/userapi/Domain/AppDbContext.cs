using Microsoft.EntityFrameworkCore;

namespace userapi.Domain
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));

        }
        public DbSet<Users.Users> Users { get; set; }

    }
}
