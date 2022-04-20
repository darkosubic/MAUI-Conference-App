using ConferenceApp.Models;
using ConferenceApp.Resources.Strings;

namespace ConferenceApp.ViewModels
{
    public class ShellViewModel
    {
        public AppSectionDto Home { get; set; }
        public AppSectionDto Presenters { get; set; }
        public AppSectionDto Agenda { get; set; }

        public ShellViewModel()
        {
            Home = new AppSectionDto() { Title = ViewsResource.Home_Xaml, Icon = "home.svg", TargetType = typeof(HomePage) };
            Presenters = new AppSectionDto() { Title = ViewsResource.Presenters_Xaml, Icon = "people.svg", TargetType = typeof(PresentersPage) };
            Agenda = new AppSectionDto() { Title = ViewsResource.Schedule_Xaml, Icon = "schedule.svg", TargetType = typeof(AgendaPage) };
        }
    }
}
