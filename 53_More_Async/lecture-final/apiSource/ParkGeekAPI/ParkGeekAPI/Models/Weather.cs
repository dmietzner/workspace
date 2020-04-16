using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkGeekAPI.Models
{
    public class Weather
    {
        public string parkCode { get; set; }
        public int fiveDayForecastValue { get; set; }
        public double low { get; set; }
        public double high { get; set; }
        public string forecast { get; set; }
        public string temperaturePreference { get; set; } = "F";
        [JsonProperty("lowTemp")]
        public double convertedLowTemp
        {
            get
            {
                return temperaturePreference.ToUpper() == "F" ? low : (low - 32) * (5.0 / 9.0);
            }
        }
        [JsonProperty("highTemp")]
        public double convertedHighTemp
        {
            get
            {
                return temperaturePreference.ToUpper() == "F" ? high : (high - 32) * (5.0 / 9.0);
            }
        }

        public Weather() { }

        public Weather(DarkSkyWeatherData darkSkyWeatherData,string parkCode, string temperaturePreference)
        {
            string ucTP = temperaturePreference.ToUpper();
            this.parkCode = parkCode;
            forecast = mapWeatherSummary(darkSkyWeatherData.summary);
            // what's the temperature preference?
            this.temperaturePreference = temperaturePreference;
            low = darkSkyWeatherData.temperatureLow;
            high = darkSkyWeatherData.temperatureHigh;

        }

        public string Recommendation
        {
            get
            {
                string result = "";
                switch (forecast.ToLower().Replace(" ", ""))
                {
                    case "snow":
                        result += "Better pack snowshoes. ";
                        break;
                    case "rain":
                        result += "Please pack rain gear and wear waterproof shoes. ";
                        break;
                    case "thunderstorms":
                        result += "Seek shelter and avoid hiking on exposed ridges! ";
                        break;
                    case "sun":
                        result += "Pack some sun block. ";
                        break;
                    default:
                        break;
                }

                // check temperature
                if (high > 75 || low > 75)
                {
                    result += "Bring an extra gallon of water. ";
                }
                if (high - low > 20)
                {
                    result += "Wear breathable layers.";
                }
                if (high < 20 || low < 20)
                {
                    result += "Beware the dangers of exposure in frigid temperatures. ";
                }

                return result;
            }
        }

        private string mapWeatherSummary(string dsWeatherSummary)
        {
            string result = "sunny";
            // map darksky to weather
            if (dsWeatherSummary.Contains("cloudy"))
            {
                result = "cloudy";
            }
            if (dsWeatherSummary.Contains("rain"))
            {
                result = "rain";
            }
            if (dsWeatherSummary.Contains("partly"))
            {
                result = "partlyCloudy";
            }
            if (dsWeatherSummary.Contains("thunder"))
            {
                result = "thunderstorms";
            }
            if (dsWeatherSummary.Contains("snow"))
            {
                result = "snow";
            }
            return result;


        }

    }
}
