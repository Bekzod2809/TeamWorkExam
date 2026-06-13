using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeamWork.Entities;
 
namespace YourProject.Data.Configurations;
 
public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories");
 
        builder.HasKey(c => c.CategoryId);
 
        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(100);
    }
}
