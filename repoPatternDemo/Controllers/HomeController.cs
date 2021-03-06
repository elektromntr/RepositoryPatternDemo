﻿using System;
using AutoMapper;
using Model;
using repoPatternDemo.ViewModels;
using Service;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Mvc;

namespace Web.ViewModels
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

        // GET: Filtered
        public ActionResult Filter(string city, string heroName)
        {
            IEnumerable<HeroViewModel> viewModelHeroes;
            IEnumerable<Hero> heroes;

            heroes = heroService.GetCityHeroes(city, heroName);
            viewModelHeroes = Mapper.Map<IEnumerable<Hero>, IEnumerable<HeroViewModel>>(heroes);

            return View(viewModelHeroes);
        }

        // POST: New Hero
        [HttpPost]
        public ActionResult Create(HeroFormViewModel newHero)
        {
            try
            {
                if (newHero != null)
                {
                    var hero = Mapper.Map<HeroFormViewModel, Hero>(newHero);
                    heroService.CreateHero(hero);

                    heroService.SaveHero();
                }
                var city = cityService.GetCity(newHero.HeroCity);
                return RedirectToAction("Index", new { city = city.Name });
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
            
        }

        // GET: Hero Edit
        public ActionResult EditHero(int id)
        {
            var hero = heroService.GetHero(id);
            return View(hero);
        }

        // POST: Hero Edit
        [HttpPost]
        public ActionResult EditHero(Hero hero)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    heroService.UpdateHero(hero);
                    heroService.SaveHero();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("","Zapis zakończony niepowodzeniem");
            }

            return View(hero);

        }
    }
}