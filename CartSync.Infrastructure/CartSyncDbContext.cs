using CartSync.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CartSync.Infrastructure;

/// <summary>
/// CartSync Database Context.
/// </summary>
public class CartSyncDbContext : DbContext
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CartSyncDbContext"/> class.
    /// </summary>
    public CartSyncDbContext() : base()
    {
        
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CartSyncDbContext"/> class.
    /// </summary>
    public CartSyncDbContext(DbContextOptions<CartSyncDbContext> options) : base(options)
    {
        
    }

    /// <summary>
    /// Gets or sets Item Categories Database Set.
    /// </summary>
    public DbSet<ItemCategoryEntity> ItemCategories { get; set; }

    /// <summary>
    /// Gets or sets Users Database Set.
    /// </summary>
    public DbSet<UserEntity> Users { get; set; }

    /// <summary>
    /// Gets or sets Lists Database Set.
    /// </summary>
    public DbSet<ListEntity> Lists { get; set; }

    /// <summary>
    /// Gets or sets Items Database Set.
    /// </summary>
    public DbSet<ItemEntity> Items { get; set; }
}
