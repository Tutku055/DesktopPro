using System;

namespace DesktopPro.Application.Features.Workspaces.DTOs;

public record WorkspaceDetailDto
{
    public Guid Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public bool IsTemporal { get; init; }
    public string? IconName { get; init; }
    public DateTime? ExpiresAtUtc { get; init; }
    public DateTime CreatedAt { get; init; }

    // Future additions: WorkspaceGroups, VirtualFiles
}