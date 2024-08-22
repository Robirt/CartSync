namespace CartSync.Infrastructure.Repositories;

using CartSync.Domain.Entities;

/// <summary>
/// <see cref="ListEntity"/> Repository.
/// </summary>
public interface IListsRepository
{
    /// <summary>
    /// Gets Lists.
    /// </summary>
    /// <param name="cancellationToken">Cancellation Token.</param>
    /// <returns>Lists.</returns>
    Task<List<ListEntity>> GetListsByUserIdAsync(int userId, CancellationToken cancellationToken);

    /// <summary>
    /// Gets List by Id.
    /// </summary>
    /// <param name="id">Id.</param>
    /// <param name="cancellationToken">Cancellation Token.</param>
    /// <returns>List.</returns>
    Task<ListEntity?> GetListByIdAsync(int id, CancellationToken cancellationToken);

    /// <summary>
    /// Adds List.
    /// </summary>
    /// <param name="list">List.</param>
    /// <param name="cancellationToken">Cancellation Token.</param>
    Task AddListAsync(ListEntity list, CancellationToken cancellationToken);

    /// <summary>
    /// Updates List.
    /// </summary>
    /// <param name="list">List.</param>
    /// <param name="cancellationToken">Cancellation Token.</param>
    Task UpdateListAsync(ListEntity list, CancellationToken cancellationToken);

    /// <summary>
    /// Removes List.
    /// </summary>
    /// <param name="list">List.</param>
    /// <param name="cancellationToken">Cancellation Token.</param>
    Task RemoveListAsync(ListEntity list, CancellationToken cancellationToken);
}
