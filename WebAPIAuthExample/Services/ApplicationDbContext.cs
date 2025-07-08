using Microsoft.EntityFrameworkCore;
using WebAPIAuthExample.Models;

namespace WebAPIAuthExample.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Users> Users { get; set; } = null!;
        public DbSet<Company> companies { get; set; } = null!;
        public DbSet<UserRoles> UserRoles { get; set; } = null!;
    }
}
