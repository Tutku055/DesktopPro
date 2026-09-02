using DesktopPro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesktopPro.Persistence.Configurations;

public class AiTriageSuggestionConfiguration : IEntityTypeConfiguration<AiTriageSuggestion>
{
    public void Configure(EntityTypeBuilder<AiTriageSuggestion> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.VirtualFile)
               .WithMany() 
               .HasForeignKey(x => x.VirtualFileId)
               .OnDelete(DeleteBehavior.Cascade); 

        builder.Property(x => x.SuggestedName)
               .IsRequired()
               .HasMaxLength(255);

        builder.Property(x => x.SuggestedWorkspaceName)
               .HasMaxLength(100);
    }
}