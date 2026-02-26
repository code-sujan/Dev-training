using Dotnet_Mvc.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_Mvc.Data;

public class ApplicationDbContext(IConfiguration configuration) : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder
            .UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
    }

    public DbSet<User> User { get; set; }
}