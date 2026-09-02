using DesktopPro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesktopPro.Persistence.Configurations;

public class WorkspaceGroupConfiguration : IEntityTypeConfiguration<WorkspaceGroup>
{
    public void Configure(EntityTypeBuilder<WorkspaceGroup> builder)
    {
        builder.HasKey(x => x.Id);

        
        builder.HasOne(x => x.Workspace)
               .WithMany(x => x.WorkspaceGroups)
               .HasForeignKey(x => x.WorkspaceId)
               .OnDelete(DeleteBehavior.Cascade);

        builder.Property(x => x.Name)
               .IsRequired()
               .HasMaxLength(100);
    }
}