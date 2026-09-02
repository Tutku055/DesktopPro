using DesktopPro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesktopPro.Persistence.Configurations
{
    public class AppUserConfiguration: IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(x=> x.Id);

            builder.Property(x => x.Username)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.PasswordHash)
                .IsRequired()
                .HasMaxLength (256);

            builder.HasIndex(x => x.Username)
                .IsUnique();
        }
    }
}
