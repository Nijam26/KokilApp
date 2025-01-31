using KokilApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace KokilApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Post> Posts { get; set; }

        /*  // Example DbSet for a User entity
          public DbSet<User> Users { get; set; }

          protected override void OnModelCreating(ModelBuilder modelBuilder)
          {
              base.OnModelCreating(modelBuilder);

              // Configure entity relationships or constraints here if needed
          }*/
    }
}
