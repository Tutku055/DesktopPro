using DesktopPro.Application.Common.Interfaces;
using DesktopPro.Domain.Entities;
using MediatR;

namespace DesktopPro.Application.Features.Workspaces.Commands.CreateWorkspace
{
    public sealed class CreateWorkspaceCommandHandler: IRequestHandler<CreateWorkspaceCommand,Guid>
    {
        private readonly IAppDbContext _context;

        public CreateWorkspaceCommandHandler(IAppDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateWorkspaceCommand request, CancellationToken cancellationToken)
        {
            var workspace = new Workspace(
                request.AppUserId,
                request.CreateWorkspaceDto.Name,
                request.CreateWorkspaceDto.IsTemporal,
                request.CreateWorkspaceDto.ExpiresAtUtc,
                request.CreateWorkspaceDto.IconName
            );
            _context.Workspaces.Add(workspace);
            await _context.SaveChangesAsync(cancellationToken);

            return workspace.Id;
        }
    }
}
