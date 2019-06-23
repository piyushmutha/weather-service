using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherService
{
    public interface IMain
    {
        double temp { get; set; }
        double pressure { get; set; }
        double humidity { get; set; }
        double temp_min { get; set; }
        double temp_max { get; set; }
        string ToString();
    }
}
