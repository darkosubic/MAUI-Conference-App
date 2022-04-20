using ConferenceApp.Models;
using ConferenceApp.Services;

namespace ConferenceApp;

public partial class PresentersPage : ContentPage
{
	public PresentersPage()
	{
        InitializeComponent();

        VipPresenters = new List<PresentersBaseDto>();
        Presenters = new List<PresentersBaseDto>();

        InitializeData();

        BindingContext = this;
    }

    private void InitializeData()
    {
        foreach (var item in PresenterService.GetAll().Take(2))
        {
            VipPresenters.Add(item);
        }
        foreach (var item in PresenterService.GetAll().Skip(2))
        {
            Presenters.Add(item);
        }
    }

    public IList<PresentersBaseDto> VipPresenters { get; set; }
    public IList<PresentersBaseDto> Presenters { get; set; }
}