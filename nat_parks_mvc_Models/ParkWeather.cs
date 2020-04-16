﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Web.Models
{
    public class ParkWeather
    {
        public Park Park { get; set; }
        public IList<Weather> Weathers { get; set; }
        public string TempScale { get; set; }
        public ParkWeather()
        {
            TempScale = "F";
        }
    }
}
