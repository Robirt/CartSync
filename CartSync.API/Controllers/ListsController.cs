using CartSync.Application.Services;
using CartSync.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CartSync.API.Controllers;

/// <summary>
/// <see cref="ListEntity"/> Controller.
/// </summary>
[Route("[controller]")]
[ApiController]
public class ListsController : ControllerBase
{
    private readonly IListsService _listsService;

    /// <summary>
    /// Initializes a new instance of the <see cref="ListsController"/> class.
    /// </summary>
    /// <param name="listsService">Lists Service.</param>
    public ListsController(IListsService listsService)
    {
        ArgumentNullException.ThrowIfNull(listsService, nameof(listsService));

        _listsService = listsService;
    }

    /// <summary>
    /// Gets Lists.
    /// </summary>
    /// <param name="cancellationToken">Cancellation Token.</param>
    /// <returns>Lists.</returns>
    [HttpGet]
    public async Task<ActionResult<List<ListEntity>>> GetListsAsync(CancellationToken cancellationToken = default)
    {
        return Ok(await _listsService.GetListsByUserIdAsync(Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)!.Value), cancellationToken));
    }

    /// <summary>
    /// Gets List by Id.
    /// </summary>
    /// <param name="id">Id.</param>
    /// <param name="cancellationToken">Cancellation Token.</param>
    /// <returns>List.</returns>
    [HttpGet("{id:int}")]
    public async Task<ActionResult<ListEntity?>> GetListByIdAsync([FromRoute] int id, CancellationToken cancellationToken = default)
    {
        var list = await _listsService.GetListByIdAsync(id, cancellationToken);

        if (list is null) return NotFound();

        if (!list.Owners.Any(owner => owner.Id == Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)!.Value))) return Forbid();

        return Ok(list);
    }

    /// <summary>
    /// Adds List.
    /// </summary>
    /// <param name="list">List.</param>
    /// <param name="cancellationToken">Cancellation Token.</param>
    [HttpPost]
    public async Task<ActionResult> AddListAsync([FromBody] ListEntity list, CancellationToken cancellationToken = default)
    {
        await _listsService.AddListAsync(list, cancellationToken);

        return Created();
    }

    /// <summary>
    /// Updates List.
    /// </summary>
    /// <param name="list">List.</param>
    /// <param name="cancellationToken">Cancellation Token.</param>
    [HttpPut]
    public async Task<ActionResult> UpdateListAsync([FromBody] ListEntity list, CancellationToken cancellationToken = default)
    {
        if ((await _listsService.GetListByIdAsync(list.Id, cancellationToken))!.Owners.Any(owner => owner.Id == Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)!.Value))) return Forbid();

        await _listsService.UpdateListAsync(list, cancellationToken);

        return NoContent();
    }

    /// <summary>
    /// Removes List.
    /// </summary>
    /// <param name="id">Id.</param>
    /// <param name="cancellationToken">Cancellation Token.</param>
    [HttpDelete("{id:int}")]
    public async Task<ActionResult> RemoveListAsync([FromRoute] int id, CancellationToken cancellationToken = default)
    {
        await _listsService.RemoveListAsync(id, cancellationToken);

        return NoContent();
    }
}
