using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class RepoPatternDemoSeedData : DropCreateDatabaseIfModelChanges<RepoPatternDemoEntities>
    {
        protected override void Seed(RepoPatternDemoEntities context)
        {
            GetCities().ForEach(c => context.Cities.Add(c));
            GetHeroes()ForEach(h => context.Heroes.Add(h));

            context.Commit();
        }

        private static List<City> GetCities()
        {
            return new List<City>
            {
                new City
                {
                    Name = "Wrocław"
                },
                new City
                {
                    Name = "Warszawa"
                },
                new City
                {
                    Name = "Lublin"
                }
            };
        }
    }
}
