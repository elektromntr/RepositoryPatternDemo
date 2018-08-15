using AutoMapper;
using Model;
using Service;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Web
{
    public class HomeController : Controller
    {
        private readonly ICityService cityService;
        private readonly IHeroService heroService;

        public HomeController(ICityService cityService, IHeroService heroService)
        {
            this.cityService = cityService;
            this.heroService = heroService;
        }

        // GET: Home
        public ActionResult Index(string city = null)
        {
            IEnumerable<CityViewModel> viewModelHeroes;
            IEnumerable<City> cities;

            cities = cityService.GetCities(city).ToList();

            viewModelHeroes = Mapper.Map<IEnumerable<City>, IEnumerable<CityViewModel>>(cities);

            return View(viewModelHeroes);
        }
    }
}