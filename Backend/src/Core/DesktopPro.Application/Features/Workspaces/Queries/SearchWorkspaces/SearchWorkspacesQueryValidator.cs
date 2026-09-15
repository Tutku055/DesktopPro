using FluentValidation;

namespace DesktopPro.Application.Features.Workspaces.Queries.SearchWorkspaces;

public sealed class SearchWorkspacesQueryValidator : AbstractValidator<SearchWorkspacesQuery>
{
    public SearchWorkspacesQueryValidator()
    {
        RuleFor(x => x.SearchTerm)
            .NotEmpty().WithMessage("Search term cannot be empty.");
            
        RuleFor(x => x.AppUserId)
            .NotEmpty().WithMessage("AppUserId is required.");
    }
}
