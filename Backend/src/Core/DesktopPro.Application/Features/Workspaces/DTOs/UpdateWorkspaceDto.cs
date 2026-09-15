using System;

namespace DesktopPro.Application.Features.Workspaces.DTOs;

public sealed record UpdateWorkspaceDto(
    string Name,
    bool IsTemporal,
    DateTime? ExpiresAtUtc,
    string? IconName
);
