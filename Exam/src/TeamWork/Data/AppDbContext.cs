using Microsoft.EntityFrameworkCore;

namespace TeamWork.Data;

public class AppDbContext : DbContext
{



    public AppDbContext(DbContextOptions<AppDbContext> options)
     : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(AppDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}
// push 001