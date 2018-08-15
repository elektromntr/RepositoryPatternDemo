﻿using System.Collections.Generic;

namespace Model
{
    public class City
    {
        public int CityID { get; set; }
        public string Name { get; set; }

        public virtual List<Hero> Heroes { get; set; }
    }
}
