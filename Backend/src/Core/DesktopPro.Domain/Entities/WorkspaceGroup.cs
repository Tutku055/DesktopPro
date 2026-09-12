using System;
using System.Collections.Generic;

namespace DesktopPro.Domain.Entities;

/// <summary>
/// Acts as a "Virtual Folder" inside a Workspace to support folder drag-and-drop and nested directories.
/// </summary>
public class WorkspaceGroup : BaseEntity
{
    public Guid WorkspaceId { get; private set; }

    /// <summary>
    /// Virtual folder name. Max length configured in persistence: 100.
    /// </summary>
    public string Name { get; private set; } = string.Empty;

    /// <summary>
    /// Parent group ID to support nested virtual folders when a directory hierarchy is dragged and dropped.
    /// </summary>
    public Guid? ParentGroupId { get; private set; }

    // Navigation properties
    public Workspace Workspace { get; private set; } = null!;
    public WorkspaceGroup? ParentGroup { get; private set; }
    public ICollection<WorkspaceGroup> SubGroups { get; private set; } = new List<WorkspaceGroup>();
    public ICollection<FileWorkspaceLink> FileLinks { get; private set; } = new List<FileWorkspaceLink>();

    protected WorkspaceGroup()
    {
        SubGroups = new List<WorkspaceGroup>();
        FileLinks = new List<FileWorkspaceLink>();
    }

    public WorkspaceGroup(Guid workspaceId, string name, Guid? parentGroupId = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name);

        WorkspaceId = workspaceId;
        Name = name;
        ParentGroupId = parentGroupId;
        SubGroups = new List<WorkspaceGroup>();
        FileLinks = new List<FileWorkspaceLink>();
    }

    public void Rename(string newName)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(newName);
        Name = newName;
        UpdatedAt = DateTime.UtcNow;
    }

    public void MoveToParentGroup(Guid? newParentId)
    {
        if (newParentId.HasValue && newParentId.Value == Id)
        {
            throw new InvalidOperationException("A group cannot be its own parent group.");
        }

        ParentGroupId = newParentId;
        UpdatedAt = DateTime.UtcNow;
    }
}
