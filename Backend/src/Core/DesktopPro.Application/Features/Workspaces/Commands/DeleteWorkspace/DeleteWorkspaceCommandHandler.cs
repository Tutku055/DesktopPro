using DesktopPro.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DesktopPro.Application.Features.Workspaces.Commands.DeleteWorkspace;

public sealed class DeleteWorkspaceCommandHandler : IRequestHandler<DeleteWorkspaceCommand>
{
    private readonly IAppDbContext _context;

    public DeleteWorkspaceCommandHandler(IAppDbContext context)
    {
        _context = context;
    }

    public async Task Handle(DeleteWorkspaceCommand request, CancellationToken cancellationToken)
    {
        var workspace = await _context.Workspaces
            .FirstOrDefaultAsync(w => w.Id == request.WorkspaceId && w.AppUserId == request.AppUserId, cancellationToken);

        if (workspace == null)
        {
            throw new KeyNotFoundException("Workspace not found");
        }

        _context.Workspaces.Remove(workspace);
        await _context.SaveChangesAsync(cancellationToken);
    }
}
