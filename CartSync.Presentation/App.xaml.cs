﻿namespace CartSync.Presentation;

/// <summary>
/// App.
/// </summary>
public partial class App : Application
{
    /// <summary>
    /// Initializes a new instance of the <see cref="App"/> class.
    /// </summary>
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }
}
