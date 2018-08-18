using System.Collections.Generic;

namespace Web.ViewModels
{
    public class HeroViewModel
    {
        public int HeroID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int Fitness { get; set; }
        public int Mind { get; set; }
        public int Empathy { get; set; }

        public int Stars { get; set; }

        public int CityID { get; set; }
    }
}