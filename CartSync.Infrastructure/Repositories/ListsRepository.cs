using CartSync.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CartSync.Infrastructure.Repositories;

/// <summary>
/// Implementation of the <see cref="IListsRepository"/> service.
/// </summary>
public sealed class ListsRepository : IListsRepository
{
    private readonly CartSyncDbContext _cartSyncDbContext;

    /// <summary>
    /// Initializes a new instance of the <see cref="ListsRepository"/> class.
    /// </summary>
    /// <param name="cartSyncDbContext">CartSync Database Context.</param>
    public ListsRepository(CartSyncDbContext cartSyncDbContext)
    {
        _cartSyncDbContext = cartSyncDbContext;
    }

    /// <inheritdoc />
    public async Task<List<ListEntity>> GetListsByUserIdAsync(int userId, CancellationToken cancellationToken)
    {
        return await _cartSyncDbContext.Lists.Include(lists => lists.Items).ThenInclude(items => items.ItemCategory).Include(lists => lists.Owners).Where(lists => lists.Owners.Any(owner => owner.Id == userId)).ToListAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ListEntity?> GetListByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _cartSyncDbContext.Lists.Include(lists => lists.Items).ThenInclude(items => items.ItemCategory).Include(lists => lists.Owners).FirstOrDefaultAsync(list => list.Id == id, cancellationToken);
    }

    /// <inheritdoc />
    public async Task AddListAsync(ListEntity list, CancellationToken cancellationToken)
    {
        await _cartSyncDbContext.Lists.AddAsync(list, cancellationToken);

        await _cartSyncDbContext.SaveChangesAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task UpdateListAsync(ListEntity list, CancellationToken cancellationToken)
    {
        _cartSyncDbContext.Lists.Update(list);

        await _cartSyncDbContext.SaveChangesAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task RemoveListAsync(ListEntity list, CancellationToken cancellationToken)
    {
        _cartSyncDbContext.Remove(list);

        await _cartSyncDbContext.SaveChangesAsync(cancellationToken);
    }
}
