using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class HeroRepository : RepositoryBase<Hero>, IHeroRepository
    {
        public HeroRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public Hero GetHeroByName(string heroName)
    {
        var hero = this.DbContext.Heroes.Where(h => h.Name == heroName).FirstOrDefault();

        return hero;
    }

    public Hero GetHeroesByCity(string cityId)
    {
        var heroes = this.DbContext.Heroes.Where(h => h.CityID == cityId);

        return heroes.ToList();
    }

    public interface IHeroRepository : IRepository<Hero>
    {

    }
}
