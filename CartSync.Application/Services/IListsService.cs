using CartSync.Domain.Entities;

namespace CartSync.Application.Services;

/// <summary>
/// <see cref="ListEntity"/> Service.
/// </summary>
public interface IListsService
{
    /// <summary>
    /// Gets Lists by User Id.
    /// </summary>
    /// <param name="userId">User Id.</param>
    /// <param name="cancellationToken">Cancellation Token.</param>
    /// <returns>Lists.</returns>
    Task<List<ListEntity>> GetListsByUserIdAsync(int userId, CancellationToken cancellationToken);

    /// <summary>
    /// Gets List by Id.
    /// </summary>
    /// <param name="id">Id.</param>
    /// <param name="cancellationToken">Cancellation Token.</param>
    /// <returns></returns>
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
    /// Removes List by Id.
    /// </summary>
    /// <param name="id">Id.</param>
    /// <param name="cancellationToken">Cancellation Token.</param>
    Task RemoveListByIdAsync(int id, CancellationToken cancellationToken);
}
