using Microsoft.EntityFrameworkCore;
using TeamWork.Entities;

namespace TeamWork.Data;

public class AppDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Food> Foods { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
     : base(options)
    {
    }
}
// push 001