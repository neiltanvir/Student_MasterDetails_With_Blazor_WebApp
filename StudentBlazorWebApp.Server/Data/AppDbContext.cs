using Microsoft.EntityFrameworkCore;
using StudentBlazorWebApp.Shared;

namespace StudentBlazorWebApp.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
