using FluentValidation;

namespace DesktopPro.Application.Features.Workspaces.Queries.GetWorkspaceById;

public class GetWorkspaceByIdQueryValidator : AbstractValidator<GetWorkspaceByIdQuery>
{
    public GetWorkspaceByIdQueryValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.AppUserId).NotEmpty();
    }
}