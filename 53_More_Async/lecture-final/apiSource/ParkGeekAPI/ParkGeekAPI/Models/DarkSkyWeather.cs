using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkGeekAPI.Models
{
    public class DarkSkyWeather
    {
        public string summary { get; set; }
        public string icon { get; set; }
        public List<DarkSkyWeatherData> data { get; set; }

    }
}
