using System;
using System.Collections.Generic;
using System.Text;

namespace DesktopPro.Application.Features.Workspaces.DTOs
{
    public sealed record WorkspaceDto(
        Guid Id,
        string Name,
        string? IconPath,
        bool IsTemporal,
        DateTime? ExpiresAtUtc,
        DateTime CreatedAt
    );
    
}
