using System;
using System.Collections.Generic;
using System.Text;

namespace DesktopPro.Domain.Entities
{
    public class Workspace: BaseEntitiy
    {
        public Guid AppUserId { get; private set; }
        public string Name { get; private set; }
        public bool IsTemporal { get; private set; }
        public string? IconPath { get; private set; }
        public DateTime? ExpiresAtUtc { get; private set; }

        //Navigation properties
        public ICollection<FileWorkspaceLink> FileLinks { get; private set; } = new List<FileWorkspaceLink>();
        public ICollection<WorkspaceGroup> WorkspaceGroups { get; private set; } = new List<WorkspaceGroup>();

        private Workspace() { }

        public Workspace(Guid appUserId, string name, bool isTemporal = false, string? iconPath = null, DateTime? expiresAtUtc = null)
        {
            AppUserId = appUserId;
            Name = name;
            IsTemporal = isTemporal;
            IconPath = iconPath;
            ExpiresAtUtc = expiresAtUtc;
        }

        public void Rename(string newName)
        {
            Name = newName;
            UpdatedAt = DateTime.UtcNow;
        }

        public void UpdateExpiration(DateTime? newExpiration)
        {
            ExpiresAtUtc = newExpiration;
            UpdatedAt = DateTime.UtcNow;
        }

        public void MakePermanent()
        {
            IsTemporal = false;
            ExpiresAtUtc = null;
            UpdatedAt = DateTime.UtcNow;
        }

        public void MakeTemporal(DateTime? expiresAtUtc)
        {
            IsTemporal = true;
            ExpiresAtUtc = expiresAtUtc;
            UpdatedAt = DateTime.UtcNow;
        }

        public void UpdateIconPath(string? newIconPath)
        {
            IconPath = newIconPath;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
