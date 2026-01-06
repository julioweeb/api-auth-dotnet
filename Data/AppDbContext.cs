using api_auth.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace api_auth.Data
{
    public class AppDbContext : DbContext
    {
     public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
     {
     }

    public DbSet<User> Users { get; set; }
    }
}
