using DesktopPro.Application.Features.Workspaces.Commands.CreateWorkspace;
using DesktopPro.Application.Features.Workspaces.Commands.UpdateWorkspace;
using DesktopPro.Application.Features.Workspaces.Queries.GetWorkspaces;
using DesktopPro.Application.Features.Workspaces.Queries.GetWorkspaceById;
using DesktopPro.Application.Features.Workspaces.Queries.SearchWorkspaces;
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

    [HttpPut("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> UpdateWorkspaceAsync(
        [FromRoute] Guid id,
        [FromBody] UpdateWorkspaceDto updateWorkspaceDto,
        CancellationToken cancellationToken)
    {
        var currentUserId = Guid.Parse("A1B2C3D4-E5F6-7890-ABCD-EF1234567890");
        
        var command = new UpdateWorkspaceCommand(id, currentUserId, updateWorkspaceDto);
        await _sender.Send(command, cancellationToken);
        return NoContent();
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

    [HttpGet("{id:guid}")]
    [ProducesResponseType(typeof(WorkspaceDetailDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetWorkspaceByIdAsync(
        [FromRoute] Guid id,
        CancellationToken cancellationToken)
    {
        var currentUserId = Guid.Parse("A1B2C3D4-E5F6-7890-ABCD-EF1234567890");

        var query = new GetWorkspaceByIdQuery(id, currentUserId);
        var workspace = await _sender.Send(query, cancellationToken);
        return Ok(workspace);
    }

    [HttpGet("search")]
    [ProducesResponseType(typeof(IReadOnlyList<WorkspaceDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> SearchWorkspacesAsync(
        [FromQuery] string q,
        CancellationToken cancellationToken)
    {
        if (string.IsNullOrWhiteSpace(q))
        {
            return Ok(Array.Empty<WorkspaceDto>());
        }

        var currentUserId = Guid.Parse("A1B2C3D4-E5F6-7890-ABCD-EF1234567890");
        var query = new SearchWorkspacesQuery(q, currentUserId);
        var workspaces = await _sender.Send(query, cancellationToken);
        return Ok(workspaces);
    }



}
