using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherService.Interfaces
{
    public interface IPersistence<TCityWeather>
    {
        bool Create(IEnumerable<ICityWeather> cityWeathers, DateTime date);
        IEnumerable<TCityWeather> GetCityWeathers(DateTime date);
    }
}
