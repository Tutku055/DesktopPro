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
        public DateTime? ExpiresAtUtc { get; private set; }

        //Navigation properties
        public ICollection<FileWorkspaceLink> FileWorkspaceLinks { get; private set; } = new List<FileWorkspaceLink>();
        public ICollection<WorkspaceGroup> WorkspaceGroups { get; private set; } = new List<WorkspaceGroup>();

        private Workspace() { }

        public Workspace(Guid appUserId, string name, bool isTemporal = false, DateTime? expiresAtUtc = null)
        {
            AppUserId = appUserId;
            Name = name;
            IsTemporal = isTemporal;
            ExpiresAtUtc = expiresAtUtc;
        }
    }
}
