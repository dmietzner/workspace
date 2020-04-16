using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkGeekAPI.Models
{
    public class DarkSkyForecast
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string timezone { get; set; }
        public int offset { get; set; }
        public DarkSkyWeatherData currently { get; set; }
        public DarkSkyWeather minutely { get; set; }
        public DarkSkyWeather hourly { get; set; }
        public DarkSkyWeather daily { get; set; }

    }
}
