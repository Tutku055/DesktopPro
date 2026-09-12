using System;
using System.Collections.Generic;
using DesktopPro.Domain.Enums;

namespace DesktopPro.Domain.Entities;

/// <summary>
/// Represents a file safely stored inside the system's Isolated Vault.
/// Physical files are organized by relative vault paths (e.g., "202609/guid_report.pdf").
/// </summary>
public class VirtualFile : BaseEntity
{
    public Guid AppUserId { get; private set; }

    /// <summary>
    /// Display name in the application. Max length configured in persistence: 255.
    /// </summary>
    public string FileName { get; private set; } = string.Empty;

    /// <summary>
    /// Original file name prior to hash/rename upon ingestion. Max length configured in persistence: 255.
    /// </summary>
    public string OriginalFileName { get; private set; } = string.Empty;

    /// <summary>
    /// Relative path within the Isolated Vault storage root (e.g., "202609/guid_report.pdf"). Max length configured in persistence: 500.
    /// </summary>
    public string VaultRelativePath { get; private set; } = string.Empty;

    /// <summary>
    /// File hash (SHA-256 is 64 hex characters; supports XxHash64) used for deduplication. Max length configured in persistence: 64.
    /// </summary>
    public string FileHash { get; private set; } = string.Empty;

    /// <summary>
    /// File size in bytes.
    /// </summary>
    public long FileSize { get; private set; }

    /// <summary>
    /// Normalized file extension with leading dot (e.g., ".pdf"). Max length configured in persistence: 32.
    /// </summary>
    public string Extension { get; private set; } = string.Empty;

    /// <summary>
    /// Organizational triage status.
    /// </summary>
    public FileStatus Status { get; private set; } = FileStatus.Inbox;

    /// <summary>
    /// Optional user-provided note or annotation. Max length configured in persistence: 2000.
    /// </summary>
    public string? UserNote { get; private set; }

    /// <summary>
    /// AI/LLM-generated contextual summary of the file content. Max length configured in persistence: 2000.
    /// </summary>
    public string? LlmSummary { get; private set; }

    /// <summary>
    /// Flag indicating whether the physical file is missing from the vault storage on disk.
    /// Managed by VaultHealthService without deleting the database record.
    /// </summary>
    public bool IsMissing { get; private set; }

    // Navigation properties
    public ICollection<FileWorkspaceLink> WorkspaceLinks { get; private set; } = new List<FileWorkspaceLink>();

    protected VirtualFile()
    {
        WorkspaceLinks = new List<FileWorkspaceLink>();
    }

    public VirtualFile(
        Guid appUserId,
        string fileName,
        string originalFileName,
        string vaultRelativePath,
        string fileHash,
        long fileSize,
        string extension,
        string? userNote = null,
        string? llmSummary = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(fileName);
        ArgumentException.ThrowIfNullOrWhiteSpace(originalFileName);
        ArgumentException.ThrowIfNullOrWhiteSpace(vaultRelativePath);
        ArgumentException.ThrowIfNullOrWhiteSpace(fileHash);
        ArgumentException.ThrowIfNullOrWhiteSpace(extension);

        AppUserId = appUserId;
        FileName = fileName;
        OriginalFileName = originalFileName;
        VaultRelativePath = vaultRelativePath;
        FileHash = fileHash;
        FileSize = fileSize;
        Extension = extension.StartsWith('.') ? extension : $".{extension}";
        Status = FileStatus.Inbox;
        UserNote = userNote;
        LlmSummary = llmSummary;
        IsMissing = false;
        WorkspaceLinks = new List<FileWorkspaceLink>();
    }

    public void Rename(string newFileName)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(newFileName);
        FileName = newFileName;
        UpdatedAt = DateTime.UtcNow;
    }

    public void MarkAsOrganized()
    {
        Status = FileStatus.Organized;
        UpdatedAt = DateTime.UtcNow;
    }

    public void MoveToRecycleBin()
    {
        Status = FileStatus.SoftDeleted;
        UpdatedAt = DateTime.UtcNow;
    }

    public void MarkAsMissing()
    {
        IsMissing = true;
        UpdatedAt = DateTime.UtcNow;
    }

    public void MarkAsFound()
    {
        IsMissing = false;
        UpdatedAt = DateTime.UtcNow;
    }

    public void UpdateLlmSummary(string? summary)
    {
        LlmSummary = summary;
        UpdatedAt = DateTime.UtcNow;
    }

    public void UpdateVaultPath(string newVaultRelativePath)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(newVaultRelativePath);
        VaultRelativePath = newVaultRelativePath;
        UpdatedAt = DateTime.UtcNow;
    }

    public void RelocateInVault(string newVaultRelativePath)
    {
        UpdateVaultPath(newVaultRelativePath);
    }

    public void UpdateUserNote(string? note)
    {
        UserNote = note;
        UpdatedAt = DateTime.UtcNow;
    }

    public void UpdateContent(string newFileName, string newFileHash, long newFileSize, string? newExtension = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(newFileName);
        ArgumentException.ThrowIfNullOrWhiteSpace(newFileHash);

        FileName = newFileName;
        FileHash = newFileHash;
        FileSize = newFileSize;

        if (!string.IsNullOrWhiteSpace(newExtension))
        {
            Extension = newExtension.StartsWith('.') ? newExtension : $".{newExtension}";
        }

        UpdatedAt = DateTime.UtcNow;
    }
}
