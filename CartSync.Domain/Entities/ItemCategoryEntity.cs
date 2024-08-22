namespace CartSync.Domain.Entities;

/// <summary>
/// Item Category Entity.
/// </summary>
public sealed class ItemCategoryEntity : EntityBase
{
    /// <summary>
    /// Gets or sets Name.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets Items.
    /// </summary>
    public List<ItemEntity> Items { get; set; } = [];
}
