using CartSync.Application.Services;
using CartSync.Infrastructure.Repositories;

namespace CartSync.API;

/// <summary>
/// <see cref="Program"/> Extensions.
/// </summary>
public static class ProgramExtensions
{
    /// <summary>
    /// Adds Repositories to the <see cref="IServiceCollection"/>.
    /// </summary>
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IListsRepository, ListsRepository>();

        return services;
    }

    /// <summary>
    /// Adds Services to the <see cref="IServiceCollection"/>.
    /// </summary>
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IListsService, ListsService>();

        return services;
    }
}
