using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DesktopPro.Application.Common.Interfaces;
using DesktopPro.Application.Features.Workspaces.DTOs;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DesktopPro.Application.Features.Workspaces.Queries.GetWorkspaceById;

public class GetWorkspaceByIdQueryHandler : IRequestHandler<GetWorkspaceByIdQuery, WorkspaceDetailDto>
{
    private readonly IAppDbContext _context;

    public GetWorkspaceByIdQueryHandler(IAppDbContext context)
    {
        _context = context;
    }

    public async Task<WorkspaceDetailDto> Handle(GetWorkspaceByIdQuery request, CancellationToken cancellationToken)
    {
        var workspace = await _context.Workspaces
            .AsNoTracking()
            .Where(w => w.Id == request.Id && w.AppUserId == request.AppUserId)
            .Select(w => new WorkspaceDetailDto
            {
                Id = w.Id,
                Name = w.Name,
                IsTemporal = w.IsTemporal,
                IconName = w.IconName,
                ExpiresAtUtc = w.ExpiresAtUtc,
                CreatedAt = w.CreatedAt
            })
            .FirstOrDefaultAsync(cancellationToken);

        if (workspace is null)
        {
            throw new KeyNotFoundException($"Workspace with ID {request.Id} was not found.");
        }

        return workspace;
    }
}