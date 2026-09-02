using DesktopPro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DesktopPro.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        //DbSet properties for entities
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<VirtualFile> VirtualFiles { get; set; }
        public DbSet<Workspace> Workspaces { get; set; }
        public DbSet<WorkspaceGroup> WorkspaceGroups { get; set; }
        public DbSet<FileWorkspaceLink> FileWorkspaceLinks { get; set; }
        public DbSet<AiTriageSuggestion> AiTriageSuggestions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
