namespace CartSync.Presentation;

/// <summary>
/// MAUI Program.
/// </summary>
public static class MauiProgram
{
    /// <summary>
    /// Creates MAUI App.
    /// </summary>
    public static MauiApp CreateMauiApp()
    {
        var mauiAppBuilder = MauiApp.CreateBuilder();

        mauiAppBuilder.UseMauiApp<App>();

        return mauiAppBuilder.Build();
    }
}
