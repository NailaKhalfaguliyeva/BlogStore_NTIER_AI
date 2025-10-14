﻿using BlogStore_NTIER_AI_EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogStore_NTIER_AI_DataAccessLayer.Configurations
{
    public class ArticleTagConfiguration : IEntityTypeConfiguration<ArticleTag>
    {
        public void Configure(EntityTypeBuilder<ArticleTag> builder)
        {
            builder.HasKey(at => new { at.ArticleId, at.TagId });

            builder.HasOne(at => at.Article)
                   .WithMany(a => a.ArticleTags)
                   .HasForeignKey(at => at.ArticleId);

            builder.HasOne(at => at.Tag)
                   .WithMany(t => t.ArticleTags)
                   .HasForeignKey(at => at.TagId);
        }
    }
}
