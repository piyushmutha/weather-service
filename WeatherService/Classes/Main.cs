using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherService
{
    public class Main : IMain
    {
        public double temp { get; set; }
        public double pressure { get; set; }
        public double humidity { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public override string ToString()
        {
            return $"Temperature = {temp}\n" +
                $"Pressure = {pressure}\n" +
                $"Humidity = {humidity}\n" +
                $"Min. Temp = {temp_min}\n" +
                $"Max. Temp = {temp_max}\n";
        }
    }
}
