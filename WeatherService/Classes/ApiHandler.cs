using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherService.Interfaces;

namespace WeatherService.Classes
{
    public class ApiHandler<TCityWeather> : IApiHandler<TCityWeather>
    {
        public TCityWeather GetCityWeather(int id)
        {
            var client = new RestClient($"{Helper.URL}?id={id}&APPID={Helper.OPEN_WEATHER_MAP_KEY}");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            var content = response.Content; 
            dynamic json = JsonConvert.DeserializeObject(content);
            JObject obj = json;
            return obj.ToObject<TCityWeather>();
        }
    }
}
