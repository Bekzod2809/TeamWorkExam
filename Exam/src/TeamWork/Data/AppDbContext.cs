using Microsoft.EntityFrameworkCore;
using TeamWork.FluentApis;
using TeamWork.Entities;
using YourProject.Data.Configurations;

namespace TeamWork.Data;

public class AppDbContext : DbContext
{



    public AppDbContext(DbContextOptions<AppDbContext> options)
     : base(options)
    {
    }

    public DbSet<Food> Foods => Set<Food>();
    public DbSet<Category> Categories => Set<Category>();
    
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(AppDbContext).Assembly);
        
        modelBuilder.ApplyConfiguration(new FoodConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}
