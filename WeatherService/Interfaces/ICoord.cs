using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherService
{
    public interface ICoord
    {
        double lon { get; set; }
        double lat { get; set; }
        string ToString();
    }
}
