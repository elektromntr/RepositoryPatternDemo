using System.Collections.Generic;

namespace Web.ViewModels
{
    public class CityViewModel
    {
        public int CityID { get; set; }
        public string Name { get; set; }

        public List<HeroViewModel> Heroes { get; set; }
    }
}