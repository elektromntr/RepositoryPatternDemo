using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class City
    {
        public int CityID { get; set; }
        public string Name { get; set; }

        public virtual List<Hero> Heroes { get; set; }
    }
}
