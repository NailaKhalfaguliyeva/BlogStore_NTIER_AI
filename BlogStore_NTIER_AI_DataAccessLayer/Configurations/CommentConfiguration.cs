using BlogStore_NTIER_AI_EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogStore_NTIER_AI_DataAccessLayer.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.CommentId);
            builder.Property(c => c.CommentDetail).HasMaxLength(1000).IsRequired();
            builder.Property(c => c.CommentDate).HasDefaultValueSql("GETDATE()");

            builder.HasOne(c => c.Article)
                   .WithMany(a => a.Comments)
                   .HasForeignKey(c => c.ArticleId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
