using CartSync.Application.Services;
using CartSync.Infrastructure;
using CartSync.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

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

    /// <summary>
    /// Migrates Database.
    /// </summary>
    public static async Task<IApplicationBuilder> MigrateDatabaseAsync(this WebApplication application)
    {
        await application.Services.CreateAsyncScope().ServiceProvider.GetRequiredService<CartSyncDbContext>().Database.MigrateAsync();

        return application;
    }
}
