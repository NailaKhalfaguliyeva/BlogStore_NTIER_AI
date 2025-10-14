using BlogStore_NTIER_AI_EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogStore_NTIER_AI_DataAccessLayer.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(u => u.Name).HasMaxLength(50);
            builder.Property(u => u.Surname).HasMaxLength(50);
            builder.Property(u => u.ImageUrl).HasMaxLength(250);
            builder.Property(u => u.Description).HasMaxLength(500);
        }
    }
}
