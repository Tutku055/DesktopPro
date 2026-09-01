using System;
using System.Collections.Generic;
using System.Text;

namespace DesktopPro.Domain.Entities
{
    public class AiTriageSuggestion: BaseEntitiy
    {
        public Guid VirtualFileId { get; private set; }
        public string SuggestedName { get; private set; }
        public Guid? SuggestedWorkspaceId { get; private set; }
        public string? SuggestedWorkspaceName { get; private set; }

        //Navigation properties
        public VirtualFile VirtualFile { get; private set; }

        private AiTriageSuggestion() { }

        public AiTriageSuggestion(Guid virtualFileId, string suggestedName, Guid? suggestedWorkspaceId = null, string? suggestedWorkspaceName = null)
        {
            VirtualFileId = virtualFileId;
            SuggestedName = suggestedName;
            SuggestedWorkspaceId = suggestedWorkspaceId;
            SuggestedWorkspaceName = suggestedWorkspaceName;
        }
    }
}
