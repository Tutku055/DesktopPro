using DesktopPro.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DesktopPro.Application.Common.Interfaces;

public interface IAppDbContext
{
    DbSet<AppUser> AppUsers { get; }
    DbSet<VirtualFile> VirtualFiles { get; }
    DbSet<Workspace> Workspaces { get; }
    DbSet<WorkspaceGroup> WorkspaceGroups { get; }
    DbSet<FileWorkspaceLink> FileWorkspaceLinks { get; }
    DbSet<AiTriageSuggestion> AiTriageSuggestions { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}