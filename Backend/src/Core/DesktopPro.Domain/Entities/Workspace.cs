using System;
using System.Collections.Generic;

namespace DesktopPro.Domain.Entities;

/// <summary>
/// Represents a logical workspace grouping files and virtual folder hierarchies.
/// </summary>
public class Workspace : BaseEntity
{
    public Guid AppUserId { get; private set; }

    /// <summary>
    /// Logical workspace name. Max length configured in persistence: 100.
    /// </summary>
    public string Name { get; private set; } = string.Empty;

    public bool IsTemporal { get; private set; }

    /// <summary>
    /// Optional UI icon identifier. Max length configured in persistence: 100.
    /// </summary>
    public string? IconName { get; private set; }

    public DateTime? ExpiresAtUtc { get; private set; }

    // Navigation properties
    public ICollection<WorkspaceGroup> WorkspaceGroups { get; private set; } = new List<WorkspaceGroup>();
    public ICollection<FileWorkspaceLink> FileLinks { get; private set; } = new List<FileWorkspaceLink>();

    protected Workspace()
    {
        WorkspaceGroups = new List<WorkspaceGroup>();
        FileLinks = new List<FileWorkspaceLink>();
    }

    public Workspace(
        Guid appUserId,
        string name,
        bool isTemporal = false,
        DateTime? expiresAtUtc = null,
        string? iconName = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name);

        AppUserId = appUserId;
        Name = name;
        IsTemporal = isTemporal;
        ExpiresAtUtc = expiresAtUtc;
        IconName = iconName;
        WorkspaceGroups = new List<WorkspaceGroup>();
        FileLinks = new List<FileWorkspaceLink>();
    }

    public void Rename(string newName)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(newName);
        Name = newName;
        UpdatedAt = DateTime.UtcNow;
    }

    public void MakeTemporal(DateTime? expiresAtUtc)
    {
        IsTemporal = true;
        ExpiresAtUtc = expiresAtUtc;
        UpdatedAt = DateTime.UtcNow;
    }

    public void MakePermanent()
    {
        IsTemporal = false;
        ExpiresAtUtc = null;
        UpdatedAt = DateTime.UtcNow;
    }

    public void UpdateIconName(string? newIconName)
    {
        IconName = newIconName;
        UpdatedAt = DateTime.UtcNow;
    }

    public void UpdateExpiration(DateTime? newExpiration)
    {
        ExpiresAtUtc = newExpiration;
        UpdatedAt = DateTime.UtcNow;
    }
}
