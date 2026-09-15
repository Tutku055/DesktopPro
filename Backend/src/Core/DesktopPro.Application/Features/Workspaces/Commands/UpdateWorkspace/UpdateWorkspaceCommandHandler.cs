using DesktopPro.Application.Common.Interfaces;
using DesktopPro.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DesktopPro.Application.Features.Workspaces.Commands.UpdateWorkspace;

public sealed class UpdateWorkspaceCommandHandler : IRequestHandler<UpdateWorkspaceCommand>
{
    private readonly IAppDbContext _context;

    public UpdateWorkspaceCommandHandler(IAppDbContext context)
    {
        _context = context;
    }

    public async Task Handle(UpdateWorkspaceCommand request, CancellationToken cancellationToken)
    {
        var workspace = await _context.Workspaces
            .FirstOrDefaultAsync(w => w.Id == request.WorkspaceId && w.AppUserId == request.AppUserId, cancellationToken);

        if (workspace == null)
        {
            throw new Exception("Workspace not found"); // Standard pattern for missing entities, could use a specific NotFoundException
        }

        workspace.Update(
            request.Dto.Name,
            request.Dto.IsTemporal,
            request.Dto.ExpiresAtUtc,
            request.Dto.IconName
        );

        await _context.SaveChangesAsync(cancellationToken);
    }
}
