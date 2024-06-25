using crudWithInterfacesUsingWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace crudWithInterfacesUsingWebAPI
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
    }
}
