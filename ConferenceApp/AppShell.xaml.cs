using ConferenceApp.ViewModels;

namespace ConferenceApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        BindingContext = new ShellViewModel();
    }
}
