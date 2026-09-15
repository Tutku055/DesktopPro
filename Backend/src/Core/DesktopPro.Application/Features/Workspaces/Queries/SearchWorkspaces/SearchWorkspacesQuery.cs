using DesktopPro.Application.Features.Workspaces.DTOs;
using MediatR;

namespace DesktopPro.Application.Features.Workspaces.Queries.SearchWorkspaces;

public sealed record SearchWorkspacesQuery(string SearchTerm, Guid AppUserId) : IRequest<IReadOnlyList<WorkspaceDto>>;
