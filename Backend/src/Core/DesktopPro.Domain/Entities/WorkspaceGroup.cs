using System;
using System.Collections.Generic;
using System.Text;

namespace DesktopPro.Domain.Entities
{
    public class WorkspaceGroup: BaseEntitiy
    {
        public Guid WorkspaceId { get; private set; }
        public string Name { get; private set; }

        //Navigation properties
        public Workspace Workspace { get; private set; }
        public ICollection<FileWorkspaceLink> FileLinks { get; private set; } = new List<FileWorkspaceLink>();


        private WorkspaceGroup() { }

        public WorkspaceGroup(Guid workspaceId, string name)
        {
            WorkspaceId = workspaceId;
            Name = name;
        }

        public void Rename(string newName)
        {
            Name = newName;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
