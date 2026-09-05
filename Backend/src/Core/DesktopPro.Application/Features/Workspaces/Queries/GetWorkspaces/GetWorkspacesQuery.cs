using DesktopPro.Application.Features.Workspaces.DTOs;
using MediatR;

namespace DesktopPro.Application.Features.Workspaces.Queries.GetWorkspaces
{
    public sealed record GetWorkspacesQuery(Guid AppUserId) : IRequest<IReadOnlyList<WorkspaceDto>>;
}
