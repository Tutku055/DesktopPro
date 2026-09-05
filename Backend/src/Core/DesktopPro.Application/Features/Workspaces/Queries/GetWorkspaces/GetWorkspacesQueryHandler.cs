using DesktopPro.Application.Features.Workspaces.DTOs;
using DesktopPro.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DesktopPro.Application.Features.Workspaces.Queries.GetWorkspaces
{
    public sealed class GetWorkspacesQueryHandler : IRequestHandler<GetWorkspacesQuery, IReadOnlyList<WorkspaceDto>>
    {
        private readonly IAppDbContext _context;

        public GetWorkspacesQueryHandler(IAppDbContext context)
        {
            _context = context;
        }

        public async Task <IReadOnlyList<WorkspaceDto>> Handle(
            GetWorkspacesQuery request,
            CancellationToken cancellationToken)
        {
            return await _context.Workspaces
                .AsNoTracking()
                .Where(w => w.AppUserId == request.AppUserId)
                .OrderByDescending(w => w.CreatedAt)
                .Select(w=> new WorkspaceDto(
                    w.Id,
                    w.Name,
                    w.IconPath,
                    w.IsTemporal,
                    w.ExpiresAtUtc,
                    w.CreatedAt
                ))
                .ToListAsync(cancellationToken);
        }
    }
}
