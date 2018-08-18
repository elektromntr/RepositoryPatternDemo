using Model;
using System.Linq;
using Data.Infrastructure;

namespace Data.Repositories
{
    public class HeroRepository : RepositoryBase<Hero>, IHeroRepository
    {
        public HeroRepository(IDbFactory dbFactory)
            : base(dbFactory) { }


        public Hero GetHeroByName(string heroName)
        {
            var hero = this.DbContext.Heroes.Where(h => h.Name == heroName).FirstOrDefault();

            return hero;
        }
    }

    public interface IHeroRepository : IRepository<Hero>
        {

        }
    
}
