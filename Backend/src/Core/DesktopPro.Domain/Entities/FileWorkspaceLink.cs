using System;
using System.Collections.Generic;
using System.Text;

namespace DesktopPro.Domain.Entities
{
    public class FileWorkspaceLink: BaseEntitiy
    {
        public Guid VirtualFileId { get; private set; }
        public Guid WorkspaceId { get; private set; }
        public Guid? WorkspaceGroupId { get; private set; }

        //Navigation properties
        public VirtualFile VirtualFile { get; private set; }
        public Workspace Workspace { get; private set; }
        public WorkspaceGroup WorkspaceGroup { get; private set; }

        private FileWorkspaceLink() { }

        public FileWorkspaceLink(Guid virtualFileId, Guid workspaceId, Guid? workspaceGroupId = null)
        {
            VirtualFileId = virtualFileId;
            WorkspaceId = workspaceId;
            WorkspaceGroupId = workspaceGroupId;
        }
    }
}
