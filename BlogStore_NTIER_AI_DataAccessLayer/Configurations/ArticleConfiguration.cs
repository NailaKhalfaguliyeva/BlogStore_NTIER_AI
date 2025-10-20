using BlogStore_NTIER_AI_EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogStore_NTIER_AI_DataAccessLayer.Configurations
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(a => a.ArticleId);
            builder.Property(a => a.Title).HasMaxLength(200).IsRequired();
            builder.Property(a => a.Description).HasMaxLength(2000);
            builder.Property(a => a.CreatedDate).HasDefaultValueSql("GETDATE()");

            

            builder.HasOne(a => a.Category)
                   .WithMany(cat => cat.Articles)
                   .HasForeignKey(a => a.CategoryId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
