namespace WeatherService.Classes
{
    public interface IApiHandler<TCityWeather>
    {
        TCityWeather GetCityWeather(int id);
    }
}