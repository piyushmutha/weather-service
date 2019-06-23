using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherService.Interfaces;

namespace WeatherService.Classes
{
    public class Persistence<TCityWeather> : IPersistence<TCityWeather> where TCityWeather:ICityWeather
    {
        public bool Create(IEnumerable<ICityWeather> cityWeathers, DateTime date)
        {
            try
            {
                string json = JsonConvert.SerializeObject(cityWeathers);
                if (!Directory.Exists("output"))
                    Directory.CreateDirectory("output");

                File.WriteAllText($"output\\W{date.ToString("yyyyMMdd")}.json", json);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<TCityWeather> GetCityWeathers(DateTime date)
        {
            string json = File.ReadAllText($"output\\W{date.ToString("yyyyMMdd")}.json");
            return JsonConvert.DeserializeObject<IEnumerable<TCityWeather>>(json);
        }
    }
}
