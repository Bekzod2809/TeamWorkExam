using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeamWork.Entities;

namespace TeamWork.FluentApis;

public class FoodConfiguration : IEntityTypeConfiguration<Food>
{
    public void Configure(EntityTypeBuilder<Food> builder)
    {
        builder.ToTable("Foods");
 
        builder.HasKey(f => f.FoodId);
 
        builder.Property(f => f.Name)
            .IsRequired()
            .HasMaxLength(200);
 
        builder.Property(f => f.Price)
            .IsRequired()
            .HasColumnType("decimal(18,2)");
 
        builder.HasOne(f => f.Category)
            .WithMany(c => c.Foods)
            .HasForeignKey(f => f.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
