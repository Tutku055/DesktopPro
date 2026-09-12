namespace DesktopPro.Application.Features.Workspaces.DTOs;

public sealed record CreateWorkspaceDto(
    string Name,
    bool IsTemporal = false,
    DateTime? ExpiresAtUtc = null,
    string? IconName = null
);