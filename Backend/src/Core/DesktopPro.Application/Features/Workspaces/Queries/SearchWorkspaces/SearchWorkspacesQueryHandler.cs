using DesktopPro.Application.Features.Workspaces.DTOs;
using DesktopPro.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DesktopPro.Application.Features.Workspaces.Queries.SearchWorkspaces;

public sealed class SearchWorkspacesQueryHandler : IRequestHandler<SearchWorkspacesQuery, IReadOnlyList<WorkspaceDto>>
{
    private readonly IAppDbContext _context;

    public SearchWorkspacesQueryHandler(IAppDbContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyList<WorkspaceDto>> Handle(
        SearchWorkspacesQuery request,
        CancellationToken cancellationToken)
    {
        return await _context.Workspaces
            .AsNoTracking()
            .Where(w => w.AppUserId == request.AppUserId && EF.Functions.Like(w.Name, $"%{request.SearchTerm}%"))
            .OrderByDescending(w => w.CreatedAt)
            .Select(w => new WorkspaceDto(
                w.Id,
                w.Name,
                w.IconName,
                w.IsTemporal,
                w.ExpiresAtUtc,
                w.CreatedAt
            ))
            .ToListAsync(cancellationToken);
    }
}
