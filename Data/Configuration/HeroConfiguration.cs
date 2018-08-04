using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class HeroConfiguration : EntityTypeConfiguration<Hero>
    {
        public HeroConfiguration()
        {
            ToTable("Heroes");
            Property(h => h.Name).IsRequired().HasMaxLength(99);
            Property(h => h.CityID).IsRequired();
        }       
    }
}
