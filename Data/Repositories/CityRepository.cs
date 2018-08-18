using Model;
using System.Linq;
using Data.Infrastructure;

namespace Data.Repositories
{
    public class CityRepository : RepositoryBase<City>, ICityRepository
    {
        public CityRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public City GetCityByName(string cityName)
        {
            var city = this.DbContext.Cities.Where(c => c.Name == cityName).FirstOrDefault();

            return city;
        }
    }

    public interface ICityRepository : IRepository<City>
        {
            City GetCityByName(string cityName);
        }   
}
