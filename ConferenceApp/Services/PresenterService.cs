using ConferenceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceApp.Services
{
    public static class PresenterService
    {
        public static List<PresentersBaseDto> GetAll()
        {
            List<PresentersBaseDto> result = new List<PresentersBaseDto>()
            {
                new PresentersBaseDto() { FullName = "Luke Benson", Image = "male1.jpg", Company = "FFW Agency" },
                new PresentersBaseDto() { FullName = "Petromira Skrinska", Image = "female1.jpg", Company = "FFW Agency" },
                new PresentersBaseDto() { FullName = "Gustav J. Jepsen", Image = "male2.jpg", Company = "FFW Agency" },
                new PresentersBaseDto() { FullName = "Claudia Lombardo", Image = "female2.jpg", Company = "FFW Agency" },
                new PresentersBaseDto() { FullName = "Virpi Anderson", Image = "female3.jpg", Company = "FFW Agency" },
                new PresentersBaseDto() { FullName = "Emilian Klaturov", Image = "female4.jpg", Company = "FFW Agency" },
                new PresentersBaseDto() { FullName = "Emilian Klaturov", Image = "male3.jpg", Company = "FFW Agency" },
                new PresentersBaseDto() { FullName = "Emilian Klaturov", Image = "male4.jpg", Company = "FFW Agency" },
                new PresentersBaseDto() { FullName = "Claudia Lombardo", Image = "female2.jpg", Company = "FFW Agency" },
                new PresentersBaseDto() { FullName = "Virpi Anderson", Image = "female3.jpg", Company = "FFW Agency" }
            };

            return result;
        }

    }

}



