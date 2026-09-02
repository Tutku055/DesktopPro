using DesktopPro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesktopPro.Persistence.Configurations
{
    public class VirtualFileConfiguration : IEntityTypeConfiguration<VirtualFile>
    {
        public void Configure(EntityTypeBuilder<VirtualFile> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne<AppUser>()
                .WithMany()
                .HasForeignKey(x => x.AppUserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.OriginalName)
               .IsRequired()
               .HasMaxLength(255);

            builder.Property(x => x.VaultPath)
                   .IsRequired()
                   .HasMaxLength(1000);

            builder.Property(x => x.FileHash)
                   .IsRequired()
                   .HasMaxLength(256);

            builder.Property(x => x.UserNote)
                   .HasMaxLength(2000);

            builder.Property(x => x.LlmSummary)
                   .HasMaxLength(2000);
        }
    }
}
