namespace CartSync.Domain.Entities;

/// <summary>
/// List Entity.
/// </summary>
public sealed class ListEntity : EntityBase
{
    /// <summary>
    /// Gets or sets Name.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets Created At.
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    /// <summary>
    /// Gets or sets Updated At.
    /// </summary>
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    /// <summary>
    /// Gets or sets Owners.
    /// </summary>
    public List<UserEntity>? Owners { get; set; }

    /// <summary>
    /// Gets or sets Items.
    /// </summary>
    public List<ItemEntity>? Items { get; set; }
}
