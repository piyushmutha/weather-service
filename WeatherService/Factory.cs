using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherService.Classes;
using WeatherService.Interfaces;

namespace WeatherService
{
    internal static class Factory
    {
        internal static ICoord newCoord() => new Coord();

        internal static IWeather newWeather() => new Weather();

        internal static IEnumerable<IWeather> newWeathers() => new List<Weather>();

        internal static IWind newWind() => new Wind();

        internal static IClouds newClouds() => new Clouds();

        internal static IMain newMain() => new Main();

        internal static ISys newSys() => new Sys();

        internal static ICityWeather newCityWeather() => new CityWeather();

        internal static IPersistence<CityWeather> newPersistence() => new Persistence<CityWeather>();

        internal static IEnumerable<ICity> GetCities()
        {
            string json = Properties.Resources.city_list_json;
            return JsonConvert.DeserializeObject<List<City>>(json);
        }

        internal static IApiHandler<CityWeather> newApiHandler()
        {
            return new ApiHandler<CityWeather>();
        }
    }
}
