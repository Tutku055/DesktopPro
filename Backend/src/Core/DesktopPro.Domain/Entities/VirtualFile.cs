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
        public FileStatus Status { get; private set; } = FileStatus.Inbox;
        public Guid AppUserId { get; private set; }

        public string? UserNote { get; private set; }
        public string? LlmSummary { get; private set; }


       //Navigation properties
       public ICollection<FileWorkspaceLink> FileWorkspaceLinks { get; private set; } = new List<FileWorkspaceLink>();

        private VirtualFile() { }

        public VirtualFile(string fileName, string originalName, string vaultPath, string fileHash, long fileSize, Guid appUserId)
        {
            FileName = fileName;
            OriginalName = originalName;
            VaultPath = vaultPath;
            FileHash = fileHash;
            FileSize = fileSize;
            AppUserId = appUserId;
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

    }
}
