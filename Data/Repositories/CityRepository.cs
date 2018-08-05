using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class CityRepository : RepositoryBase<City>, ICityRepository
    {
        public CityRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public City GetCityByName(string cityName)
        {
            var city = this.DbContext.City.Where(c => c.Name == cityName).FirstOrDefault();

            return city;
        }

        public interface ICityRepository : IRepository<City>
        {
            City GetCityByName(string cityName);
        }
    }
}
