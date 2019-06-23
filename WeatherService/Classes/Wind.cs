using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherService
{
    public class Wind : IWind
    {
        public double speed { get; set; }
        public double deg { get; set; }
        public override string ToString()
        {
            return $"Speed = {speed}\n" +
                $"Deg. = {deg}";
        }
    }
}
