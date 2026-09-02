using System;
using System.Collections.Generic;
using System.Text;
using DesktopPro.Domain.Enums;

namespace DesktopPro.Domain.Entities
{
    public class VirtualFile: BaseEntitiy
    {
        public string FileName { get; private set; }
        public string OriginalName { get; private set; }
        public string VaultPath { get; private set; }
        public string FileHash { get; private set; } = string.Empty;
        public long FileSize { get; private set; }
        public string? IconPath { get; private set; }
        public FileStatus Status { get; private set; } = FileStatus.Inbox;
        public Guid AppUserId { get; private set; }

        public string? UserNote { get; private set; }
        public string? LlmSummary { get; private set; }


       //Navigation properties
       public ICollection<FileWorkspaceLink> WorkspaceLinks { get; private set; } = new List<FileWorkspaceLink>();

        private VirtualFile() { }

        public VirtualFile(string fileName, string originalName, string vaultPath, string fileHash, Guid appUserId, long fileSize, string? iconPath = null)
        {
            FileName = fileName;
            OriginalName = originalName;
            VaultPath = vaultPath;
            FileHash = fileHash;
            FileSize = fileSize;
            AppUserId = appUserId;
            IconPath = iconPath;
        }

        public void Rename(string newFileName)
        {
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

        public void UpdateLlmSummary(string summary)
        {
            LlmSummary = summary;
            UpdatedAt = DateTime.UtcNow;
        }

        public void UpdateUserNote(string note)
        {
            UserNote = note;
            UpdatedAt = DateTime.UtcNow;
        }

        public void UpdateContent(string newFileName, string newFileHash, long newFileSize)
        {
            FileName = newFileName;
            FileHash = newFileHash;
            FileSize = newFileSize;
            UpdatedAt = DateTime.UtcNow;
        }

        public void Relocate(string newVaultPath)
        {
            VaultPath = newVaultPath;
            UpdatedAt = DateTime.UtcNow;
        }

        public void UpdateIconPath(string? newIconPath)
        {
            IconPath = newIconPath;
            UpdatedAt = DateTime.UtcNow;
        }

    }
}
