using Model;
using System.Data.Entity.ModelConfiguration;

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
