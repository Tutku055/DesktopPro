using DesktopPro.Application.Features.Workspaces.DTOs;
using MediatR;
using System;

namespace DesktopPro.Application.Features.Workspaces.Commands.UpdateWorkspace;

public sealed record UpdateWorkspaceCommand(Guid WorkspaceId, Guid AppUserId, UpdateWorkspaceDto Dto) : IRequest;
