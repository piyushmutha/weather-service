﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherService
{
    public interface ICity
    {
        int id { get; set; }
        string name { get; set; }
        string country { get; set; }
    }
}
