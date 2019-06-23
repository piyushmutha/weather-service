using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherService
{
    public class City : ICity
    {
        public int id { get ; set ; }
        public string name { get ; set ; }
        public string country { get ; set ; }
        public ICoord coord { get; set; } 
        public City()
        {
            coord = Factory.newCoord();
        }
    }
}
