using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherService
{
    public interface IWeather
    {
        int id { get; set; }
        string main { get; set; }
        string description { get; set; }
        string icon { get; set; }
        string ToString();
    }
}
