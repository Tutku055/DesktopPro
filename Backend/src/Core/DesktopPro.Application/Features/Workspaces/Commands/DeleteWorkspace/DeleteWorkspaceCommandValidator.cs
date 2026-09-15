using FluentValidation;

namespace DesktopPro.Application.Features.Workspaces.Commands.DeleteWorkspace;

public sealed class DeleteWorkspaceCommandValidator : AbstractValidator<DeleteWorkspaceCommand>
{
    public DeleteWorkspaceCommandValidator()
    {
        RuleFor(v => v.WorkspaceId)
            .NotEmpty().WithMessage("WorkspaceId is required.");

        RuleFor(v => v.AppUserId)
            .NotEmpty().WithMessage("AppUserId is required.");
    }
}
