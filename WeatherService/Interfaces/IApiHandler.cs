using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherService.Interfaces
{
    public interface IApiHandler<TCityWeather>
    {
        TCityWeather GetCityWeather(int id);
    }
}
