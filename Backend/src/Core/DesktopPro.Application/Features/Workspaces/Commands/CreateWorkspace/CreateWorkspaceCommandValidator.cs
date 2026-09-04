using FluentValidation;

namespace DesktopPro.Application.Features.Workspaces.Commands.CreateWorkspace
{
    public sealed class CreateWorkspaceCommandValidator : AbstractValidator<CreateWorkspaceCommand>
    {
        public CreateWorkspaceCommandValidator()
        {
            RuleFor(x=>x.AppUserId)
                .NotEmpty().WithMessage("AppUserId is required.")
                .NotNull().WithMessage("AppUserId cannot be null.");

            RuleFor(x=>x.CreateWorkspaceDto.Name)
                .NotNull().WithMessage("Name is required.")
                .MaximumLength(100).WithMessage("Name cannot exceed 100 characters.");

            RuleFor(x => x.CreateWorkspaceDto.IconPath)
                .MaximumLength(1000).WithMessage("IconPath cannot exceed 1000 characters.");

            When(x => x.CreateWorkspaceDto.IsTemporal, () =>
            {
                RuleFor(x => x.CreateWorkspaceDto.ExpiresAtUtc)
                    .NotNull().WithMessage("ExpiresAtUtc is required for temporal workspaces.")
                    .GreaterThan(DateTime.UtcNow).WithMessage("ExpiresAtUtc must be in the future.");
            });
        }
    }
}
