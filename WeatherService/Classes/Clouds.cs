using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherService
{
    public class Clouds : IClouds
    {
        public double all { get; set; }
        public override string ToString()
        {
            return all.ToString();
        }
    }
}
