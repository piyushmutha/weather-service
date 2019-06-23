using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherService
{
    public interface ICityWeather
    {
        ICoord coord { get; set; }
        IEnumerable<IWeather> weather { get; set; }
        string @base {get;set;}
        IMain main { get; set; }
        int Visibility { get; set; }
        IWind wind { get; set; }
        IClouds clouds { get; set; }
        long dt { get; set; }
        ISys sys { get; set; }
        int timezone { get; set; }
        int id { get; set; }
        string name { get; set; }
        int cod { get; set; }
    }
}
