using MvvmHelpers;

namespace ConferenceApp.Models
{
    public class PresentersBaseDto : ObservableObject
    {
        public string FullName { get; set; }
        public string Company { get; set; }
        public string Image { get; set; }
    }
}
