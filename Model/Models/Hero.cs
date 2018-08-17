using System;

namespace Model
{
    public class Hero
    {
        public int HeroID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        //adding photo in the future
        
        public int Fitness { get; set; }
        public int Mind { get; set; }
        public int Empathy { get; set; }

        public int Stars { get
            {
                return Fitness + Mind + Empathy;
            }
        }

        public int CityID { get; set; }
        public City City { get; set; }

        public DateTime DateCreated
        {
            set => DateCreated = DateTime.Now;
        }
    }
}
