using DesktopPro.Application.Features.Workspaces.DTOs;
using MediatR;

namespace DesktopPro.Application.Features.Workspaces.Commands.CreateWorkspace;

public sealed record CreateWorkspaceCommand(
    Guid AppUserId,
    CreateWorkspaceDto CreateWorkspaceDto
) : IRequest<Guid>;