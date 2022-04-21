using ConferenceApp.Models;
using ConferenceApp.Services;
using System.Collections.ObjectModel;

namespace ConferenceApp;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
         
        FeaturedPresenters = new List<PresentersBaseDto>();

        

        InitializeData();

        BindingContext = this;
    }

    private void InitializeData()
    {
        foreach (var item in PresenterService.GetAll())
        {
            FeaturedPresenters.Add(item);
        }
    }

    public IList<PresentersBaseDto> FeaturedPresenters { get; set; }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        string buttonText = allPresentersNavigationButton.Text;
        await Shell.Current.GoToAsync(nameof(PresentersPage));
    }
}