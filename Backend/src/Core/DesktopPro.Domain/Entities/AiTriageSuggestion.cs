using System;

namespace DesktopPro.Domain.Entities;

/// <summary>
/// AI-generated triage suggestions for renaming or relocating a VirtualFile into a Workspace.
/// </summary>
public class AiTriageSuggestion : BaseEntity
{
    public Guid VirtualFileId { get; private set; }

    /// <summary>
    /// Suggested filename for the file. Max length configured in persistence: 255.
    /// </summary>
    public string SuggestedName { get; private set; } = string.Empty;

    public Guid? SuggestedWorkspaceId { get; private set; }

    /// <summary>
    /// Suggested workspace name. Max length configured in persistence: 100.
    /// </summary>
    public string? SuggestedWorkspaceName { get; private set; }

    // Navigation properties
    public VirtualFile VirtualFile { get; private set; } = null!;

    protected AiTriageSuggestion() { }

    public AiTriageSuggestion(
        Guid virtualFileId,
        string suggestedName,
        Guid? suggestedWorkspaceId = null,
        string? suggestedWorkspaceName = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(suggestedName);

        VirtualFileId = virtualFileId;
        SuggestedName = suggestedName;
        SuggestedWorkspaceId = suggestedWorkspaceId;
        SuggestedWorkspaceName = suggestedWorkspaceName;
    }

    public void UpdateSuggestion(string suggestedName, Guid? suggestedWorkspaceId = null, string? suggestedWorkspaceName = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(suggestedName);

        SuggestedName = suggestedName;
        SuggestedWorkspaceId = suggestedWorkspaceId;
        SuggestedWorkspaceName = suggestedWorkspaceName;
        UpdatedAt = DateTime.UtcNow;
    }
}
