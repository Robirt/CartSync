namespace CartSync.Domain.Entities;

/// <summary>
/// User Entity.
/// </summary>
public sealed class UserEntity : EntityBase
{
    /// <summary>
    /// Gets or sets Name.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets Password Hash.
    /// </summary>
    public byte[]? PasswordHash { get; set; }

    /// <summary>
    /// Gets or sets Password Salt.
    /// </summary>
    public byte[]? PasswordSalt { get; set; }

    /// <summary>
    /// Gets or sets Lists.
    /// </summary>
    public List<ListEntity>? Lists { get; set; }
}
