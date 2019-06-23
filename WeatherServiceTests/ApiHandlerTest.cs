using NUnit.Framework;
using System;
using WeatherService;
using WeatherService.Classes;

namespace WeatherServiceTests
{
    [TestFixture]
    public class ApiHandlerTest
    {
        [Test]
        public void GetCityWeather()
        {
            ApiHandler<CityWeather> apiHandler = new ApiHandler<CityWeather>();

            CityWeather cityWeather = apiHandler.GetCityWeather(1275339);//ID of Mumbai City

            Assert.That(cityWeather.name == "Mumbai");// Tested that the apiHandler has successfully deserialized the object after api call.
        }
    }
}
