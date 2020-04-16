using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkGeekAPI.Models
{
    public class DarkSkyWeatherData
    {
        public long time { get; set; }
        public DateTime DateTime
        {
            get
            {
                return DateTimeOffset.FromUnixTimeSeconds(time).UtcDateTime;
            }
        }

        public string summary { get; set; }
        public string icon { get; set; }
        public double nearestStormDistance { get; set; }
        public double precipIntensity { get; set; }
        public double precipIntensityError { get; set; }
        public double precipProbability { get; set; }
        public string precipType { get; set; }
        public double temperature { get; set; }
        public double temperatureHigh { get; set; }
        public double temperatureLow { get; set; }
        public double apparentTemperature { get; set; }
        public double dewPoint { get; set; }
        public double humidity { get; set; }
        public double pressure { get; set; }
        public double windSpeed { get; set; }
        public double windGust { get; set; }
        public double windBearing { get; set; }
        public double cloudCover { get; set; }
        public double uvIndex { get; set; }
        public double visibility { get; set; }
        public double ozone { get; set; }

    }
}
