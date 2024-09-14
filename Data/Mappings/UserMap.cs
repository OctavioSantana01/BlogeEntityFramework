using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings;

public class UserMap : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> user)
    {
        user.ToTable("User");
        
        user.HasKey(x => x.Id);

        user.Property(x=> x.Name)
                .IsRequired()
                .HasColumnType("NVARCHAR")
                .HasMaxLength(100);

        user.Property(x=> x.Email)
                .IsRequired()
                .HasColumnType("NVARCHAR")
                .HasMaxLength(100);

        user.Property(x=> x.Slug)
                .IsRequired()
                .HasColumnType("NVARCHAR")
                .HasMaxLength(100);

        user.HasIndex(x=> x.Slug)
                .IsUnique();
    }
}