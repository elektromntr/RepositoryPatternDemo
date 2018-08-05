using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IHeroService
    {
        IEnumerable<Hero> GetHeroes();
        IEnumerable<Hero> GetCityHeroes(string cityName, string heroName = null);
        Hero GetHero(int id);
        void CreateHero(Hero hero);
        void SaveHero();
    }

    public class HeroService : IHeroService
    {
        private readonly IHeroRepository heroesRepository;
        private readonly ICityRepository citiesRepository;
        private readonly IUnitOfWork unitOfWork;

        public HeroService(IHeroRepository heroesRepository, ICityRepository citiesRepository, IUnitOfWork unitOfWork)
        {
            this.heroesRepository = heroesRepository;
            this.citiesRepository = citiesRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IHeroesService Members

        public IEnumerable<Hero> GetHeroes()
        {
            var heroes = heroesRepository.GetAll();

            return heroes;
        }

        public IEnumerable<Hero> GetCityHeroes(string cityName, string heroName = null)
        {
            var city = citiesRepository.GetCityByName(cityName);
            return city.Heroes.Where(h => h.Name.ToLower().Contains(heroName.ToLower().Trim()));
        }

        public Hero GetHero(int id)
        {
            var hero = heroesRepository.GetById(id);
            return hero;
        }

        public void CreateHero(Hero hero)
        {
            heroesRepository.Add(hero);
        }

        public void SaveHero()
        {
            unitOfWork.Commit();
        }
        #endregion
    }
}
