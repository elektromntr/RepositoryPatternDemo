using Model;
using System.Data.Entity.ModelConfiguration;

namespace Data.Configuration
{
    public class CityConfiguration : EntityTypeConfiguration<City>
    {
        public CityConfiguration()
        {
            ToTable("Cities");
            Property(c => c.Name).IsRequired();
        }
    }
}
