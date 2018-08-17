using Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Data
{
    public class RepoPatternDemoEntities : DbContext
    {
        public RepoPatternDemoEntities() : base("RepoPatternDemoEntities") { }

        public DbSet<Hero> Heroes { get; set; }
        public DbSet<City> Cities { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new HeroConfiguration());
            modelBuilder.Configurations.Add(new CityConfiguration());
            modelBuilder.Entity<Hero>().Ignore(h => h.Stars);
        }
    }
}
