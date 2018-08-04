using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class CityConfiguration : EntityTypeConfiguration<City>
    {
        public CityConfiguration()
        {
            ToTable("Cities");
            Property(c => c.Name).IsRequired().MaxLength(99);
        }
    }
}
