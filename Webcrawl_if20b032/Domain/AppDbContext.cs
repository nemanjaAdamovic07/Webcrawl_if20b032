using Microsoft.EntityFrameworkCore;
using Webcrawl_if20b032.Domain.Users;

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
        public DbSet<Users.User> Users { get; set; }
        public DbSet<UserHistory> UserHistory { get; set; }
    }
}
