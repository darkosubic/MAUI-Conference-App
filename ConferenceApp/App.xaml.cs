namespace ConferenceApp;

public partial class App : Application
{
	public App(AppShell shell)
    {
        InitializeComponent();

        MainPage = shell;

        RegisterRoutes();
    }

    private static void RegisterRoutes()
    {
        Routing.RegisterRoute(nameof(AgendaPage), typeof(AgendaPage));
        Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
        Routing.RegisterRoute(nameof(PresentersPage), typeof(PresentersPage));
    }
}
