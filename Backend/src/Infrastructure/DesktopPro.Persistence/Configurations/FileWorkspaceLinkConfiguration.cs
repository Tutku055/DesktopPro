using DesktopPro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesktopPro.Persistence.Configurations;

public class FileWorkspaceLinkConfiguration : IEntityTypeConfiguration<FileWorkspaceLink>
{
    public void Configure(EntityTypeBuilder<FileWorkspaceLink> builder)
    {
        builder.HasKey(x => x.Id);


        builder.HasOne(x => x.VirtualFile)
               .WithMany(x => x.WorkspaceLinks)
               .HasForeignKey(x => x.VirtualFileId)
               .OnDelete(DeleteBehavior.Cascade); 

        builder.HasOne(x => x.Workspace)
               .WithMany(x => x.FileLinks)
               .HasForeignKey(x => x.WorkspaceId)
               .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.WorkspaceGroup)
               .WithMany(x => x.FileLinks)
               .HasForeignKey(x => x.WorkspaceGroupId)
               .OnDelete(DeleteBehavior.SetNull);
    }
}