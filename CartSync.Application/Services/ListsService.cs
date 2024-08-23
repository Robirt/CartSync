using CartSync.Domain.Entities;
using CartSync.Infrastructure.Repositories;

namespace CartSync.Application.Services;

/// <summary>
/// Implementation of the <see cref="IListsService"/> service.
/// </summary>
public sealed class ListsService : IListsService
{
    private readonly IListsRepository _listsRepository;

    /// <summary>
    /// Initializes a new instance of the <see cref="ListsService"/> class.
    /// </summary>
    /// <param name="listsRepository">Lists Repository.</param>
    public ListsService(IListsRepository listsRepository)
    {
        ArgumentNullException.ThrowIfNull(listsRepository, nameof(listsRepository));

        _listsRepository = listsRepository;
    }

    /// <inheritdoc />
    public async Task<List<ListEntity>> GetListsByUserIdAsync(int userId, CancellationToken cancellationToken)
    {
        return await _listsRepository.GetListsByUserIdAsync(userId, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ListEntity?> GetListByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _listsRepository.GetListByIdAsync(id, cancellationToken);
    }

    /// <inheritdoc />
    public async Task AddListAsync(ListEntity list, CancellationToken cancellationToken)
    {
        list.CreatedAt = DateTime.Now;

        await _listsRepository.AddListAsync(list, cancellationToken);
    }

    /// <inheritdoc />
    public async Task UpdateListAsync(ListEntity list, CancellationToken cancellationToken)
    {
        list.UpdatedAt = DateTime.Now;

        await _listsRepository.UpdateListAsync(list, cancellationToken);
    }

    /// <inheritdoc />
    public async Task RemoveListAsync(int id, CancellationToken cancellationToken)
    {
        await _listsRepository.RemoveListAsync(await _listsRepository.GetListByIdAsync(id, cancellationToken) ?? throw new ArgumentException($"List with Id {id} not found."), cancellationToken);
    }
}
