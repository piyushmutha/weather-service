﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherService
{
    public class Sys : ISys
    {
        public int type { get; set; }
        public int id { get; set; }
        public string message { get; set; }
        public string country { get; set; }
        public long sunrise { get; set; }
        public long sunset { get; set; }
    }
}
