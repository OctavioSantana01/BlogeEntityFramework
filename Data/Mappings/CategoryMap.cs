using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings;

public class CategoryMap : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> category)
    {
        category.ToTable("Category");
        
        category.HasKey(x => x.Id);

        category.Property(x=> x.Name)
                .IsRequired()
                .HasColumnType("NVARCHAR")
                .HasMaxLength(100);

        category.Property(x=> x.Slug)
                .IsRequired()
                .HasColumnType("NVARCHAR")
                .HasMaxLength(100);

        category.HasIndex(x=> x.Slug)
                .IsUnique();
    }
}