using FluentValidation;

namespace DesktopPro.Application.Features.Workspaces.Commands.UpdateWorkspace;

public sealed class UpdateWorkspaceCommandValidator : AbstractValidator<UpdateWorkspaceCommand>
{
    public UpdateWorkspaceCommandValidator()
    {
        RuleFor(x => x.WorkspaceId).NotEmpty();
        RuleFor(x => x.AppUserId).NotEmpty();
        RuleFor(x => x.Dto).NotNull();
        
        When(x => x.Dto != null, () =>
        {
            RuleFor(x => x.Dto.Name)
                .NotEmpty().WithMessage("Workspace name cannot be empty.")
                .MaximumLength(100).WithMessage("Workspace name cannot exceed 100 characters.");
                
            RuleFor(x => x.Dto.ExpiresAtUtc)
                .NotEmpty().When(x => x.Dto.IsTemporal)
                .WithMessage("Expiration date is required for temporal workspaces.");
        });
    }
}
