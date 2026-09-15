using MediatR;
using System;

namespace DesktopPro.Application.Features.Workspaces.Commands.DeleteWorkspace;

public sealed record DeleteWorkspaceCommand(Guid WorkspaceId, Guid AppUserId) : IRequest;
