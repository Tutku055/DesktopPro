using DesktopPro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesktopPro.Persistence.Configurations;

public class VirtualFileConfiguration : IEntityTypeConfiguration<VirtualFile>
{
    public void Configure(EntityTypeBuilder<VirtualFile> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne<AppUser>()
            .WithMany()
            .HasForeignKey(x => x.AppUserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(x => x.FileName)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(x => x.OriginalFileName)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(x => x.VaultRelativePath)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(x => x.FileHash)
            .IsRequired()
            .HasMaxLength(64);

        builder.Property(x => x.FileSize)
            .IsRequired();

        builder.Property(x => x.Extension)
            .IsRequired()
            .HasMaxLength(32);

        builder.Property(x => x.Status)
            .IsRequired();

        builder.Property(x => x.UserNote)
            .HasMaxLength(2000);

        builder.Property(x => x.LlmSummary)
            .HasMaxLength(2000);

        builder.Property(x => x.IsMissing)
            .HasDefaultValue(false);

        builder.HasMany(x => x.WorkspaceLinks)
            .WithOne(x => x.VirtualFile)
            .HasForeignKey(x => x.VirtualFileId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
