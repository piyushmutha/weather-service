using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherService
{
    public class Coord:ICoord
    {
        public double lon { get; set; }
        public double lat { get; set; }

        public override string ToString()
        {
            return $"[{ lon.ToString()} , { lat.ToString()}]";
        }
    }
}
