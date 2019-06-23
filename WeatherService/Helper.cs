using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherService
{
    public static class Helper
    {
        public const string URL = "http://api.openweathermap.org/data/2.5/weather";
        public const string OPEN_WEATHER_MAP_KEY = "1f588da958aa2d4c0891db09be743334";

        public static DataTable ToDataTable(this IEnumerable<ICityWeather> cityWeathers)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new List<DataColumn>(){
                new DataColumn("Name"),
                new DataColumn("Weather"),
                new DataColumn("Main"),
                new DataColumn("Cloud"),
                new DataColumn("Visibility"),
                new DataColumn("Wind")
            }.ToArray());
            cityWeathers.All(x => 
            {
                dt.Rows.Add(x.name, x.weather.FirstOrDefault(), x.main, x.clouds, x.Visibility, x.wind);
                return true;
            });
            return dt;
        }
    }
}
