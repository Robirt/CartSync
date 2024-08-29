namespace CartSync.Domain.Entities;

/// <summary>
/// Item Entity.
/// </summary>
public sealed class ItemEntity : EntityBase
{
    /// <summary>
    /// Gets or sets Name.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets a value indicating whether Is Purchased.
    /// </summary>
    public bool IsPurchased { get; set; }

    /// <summary>
    /// Gets or sets Description.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets a value indicating whether Is Urgent.
    /// </summary>
    public bool IsUrgent { get; set; }

    /// <summary>
    /// Gets or sets Created At.
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    /// <summary>
    /// Gets or sets Item Category Id.
    /// </summary>
    public int? ItemCategoryId { get; set; }

    /// <summary>
    /// Gets or sets Item Category.
    /// </summary>
    public ItemCategoryEntity? ItemCategory { get; set; }

    /// <summary>
    /// Gets or sets List Id.
    /// </summary>
    public int? ListId { get; set; }

    /// <summary>
    /// Gets or sets List.
    /// </summary>
    public ListEntity? List { get; set; }
}
