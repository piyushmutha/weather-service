using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherService
{
    public class CityWeather : ICityWeather
    {
        public ICoord coord { get; set; }
        public IEnumerable<IWeather> weather { get; set; }
        public string @base { get; set; }
        public IMain main { get; set; }
        public int Visibility { get; set; }
        public IWind wind { get; set; }
        public IClouds clouds { get; set; }
        public long dt { get; set; }
        public ISys sys { get; set; }
        public int timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }

        public CityWeather()
        {
            coord = Factory.newCoord();
            weather = Factory.newWeathers();
            main = Factory.newMain();
            wind = Factory.newWind();
            clouds = Factory.newClouds();
            sys = Factory.newSys();
        }
    }
}
