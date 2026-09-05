using DesktopPro.Application.Features.Workspaces.Commands.CreateWorkspace;
using DesktopPro.Application.Features.Workspaces.Queries.GetWorkspaces;
using DesktopPro.Application.Features.Workspaces.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DesktopPro.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class WorkspacesController: ControllerBase
{
    private readonly ISender _sender;
    
    public WorkspacesController(ISender sender)
    {
        _sender = sender;
    }

    [HttpPost]
    [ProducesResponseType(typeof(Guid),StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> CreateWorkspaceAsync(
        [FromBody] CreateWorkspaceDto createWorkspaceDto,
        CancellationToken cancellationToken)
    {
        var currentUserId = Guid.Parse("A1B2C3D4-E5F6-7890-ABCD-EF1234567890");

        var command = new CreateWorkspaceCommand(currentUserId, createWorkspaceDto);
        var workspaceId = await _sender.Send(command, cancellationToken);
        return StatusCode(StatusCodes.Status201Created, workspaceId);
    }

    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyList<WorkspaceDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetWorkspacesAsync(
        CancellationToken cancellationToken)
    {
        var currentUserId = Guid.Parse("A1B2C3D4-E5F6-7890-ABCD-EF1234567890");

        var query = new GetWorkspacesQuery(currentUserId);
        var workspaces = await _sender.Send(query, cancellationToken);
        return Ok(workspaces);
    }



}
