using System;

namespace DesktopPro.Domain.Entities;

/// <summary>
/// Junction entity representing the placement of a VirtualFile within a Workspace and optional WorkspaceGroup (virtual folder).
/// </summary>
public class FileWorkspaceLink : BaseEntity
{
    public Guid VirtualFileId { get; private set; }
    public Guid WorkspaceId { get; private set; }
    public Guid? WorkspaceGroupId { get; private set; }

    // Navigation properties
    public VirtualFile VirtualFile { get; private set; } = null!;
    public Workspace Workspace { get; private set; } = null!;
    public WorkspaceGroup? WorkspaceGroup { get; private set; }

    protected FileWorkspaceLink() { }

    public FileWorkspaceLink(Guid virtualFileId, Guid workspaceId, Guid? workspaceGroupId = null)
    {
        VirtualFileId = virtualFileId;
        WorkspaceId = workspaceId;
        WorkspaceGroupId = workspaceGroupId;
    }

    public void MoveToGroup(Guid? newWorkspaceGroupId)
    {
        WorkspaceGroupId = newWorkspaceGroupId;
        UpdatedAt = DateTime.UtcNow;
    }
}
