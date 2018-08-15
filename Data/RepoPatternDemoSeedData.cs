using Model;
using System.Collections.Generic;
using System.Data.Entity;

namespace Data
{
    public class RepoPatternDemoSeedData : DropCreateDatabaseIfModelChanges<RepoPatternDemoEntities>
    {
        protected override void Seed(RepoPatternDemoEntities context)
        {
            GetCities().ForEach(c => context.Cities.Add(c));

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
