using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web
{
    public class HeroViewModel
    {
        public int HeroID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int Fitness { get; set; }
        public int Mind { get; set; }
        public int Empathy { get; set; }

        public int CityID { get; set; }
    }
}