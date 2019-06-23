using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherService.Interfaces
{
    public interface IApiHandler<TCityWeather> where TCityWeather : ICityWeather
    {
        TCityWeather GetCityWeather(int id);
    }
}
