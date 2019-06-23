using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherService
{
    public interface ISys
    {
        int type { get; set; }
        int id { get; set; }
        string message { get; set; }
        string country { get; set; }
        long sunrise { get; set; }
        long sunset { get; set; }
        string ToString();
    }
}
