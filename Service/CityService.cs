using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface ICityService
    {
        IEnumerable<City> GetCities(string name = null);
        City GetCity(int id);
        City GetCity(string name);
        void CreateCity(City city);
        void SaveCity();
    }

    public class CityService : ICityService
    {
        private readonly ICityRepository citiesRepository;
        private readonly IUnitOfWork unitOfWork;

        public CityService(ICityRepository citiesRepository, IUnitOfWork unitOfWork)
        {
            this.citiesRepository = citiesRepository;
            this.unitOfWork = unitOfWork;
        }

        #region ICityService Members

        public IEnumerable<City> GetCities(string name = null)
        {
            if (string.IsNullOrEmpty(name))
                return citiesRepository.GetAll();
            else
                return citiesRepository.GetAll().Where(c => c.Name == name);
        }

        public City GetCity(int id)
        {
            var city = citiesRepository.GetById(id);
            return city;
        }

        public City GetCity(string name)
        {
            var city = citiesRepository.GetCityByName(name);
            return city;
        }

        public void CreateCity(City city)
        {
            citiesRepository.Add(city);
        }

        public void SaveCity()
        {
            unitOfWork.Commit();
        }

        #endregion
    }
}
