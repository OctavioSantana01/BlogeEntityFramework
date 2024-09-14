using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings;

public class PostMap : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> post)
    {
        post.ToTable("Post");
        
        post.HasKey(x => x.Id);

        post.HasIndex(x=> x.Slug)
                .IsUnique();

        post.Property(x=> x.LastUpdateDate)
                .IsRequired()
                .HasColumnType("SMALLDATETIME")
                .HasDefaultValueSql("GETDATE()");
    }
}