using System;
using DesktopPro.Application.Features.Workspaces.DTOs;
using MediatR;

namespace DesktopPro.Application.Features.Workspaces.Queries.GetWorkspaceById;

public record GetWorkspaceByIdQuery(Guid Id, Guid AppUserId) : IRequest<WorkspaceDetailDto>;