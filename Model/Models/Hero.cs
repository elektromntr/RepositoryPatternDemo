using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Hero
    {
        public int HeroID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        
        public int Fitness { get; set; }
        public int Mind { get; set; }
        public int Emphaty { get; set; }

        public int CityID { get; set; }
        public City City { get; set; }

        public DateTime DateCreated { get; set; }

        public DateCreated()
        {
            DateCreated = DateTime.Now;
        }
    }
}
