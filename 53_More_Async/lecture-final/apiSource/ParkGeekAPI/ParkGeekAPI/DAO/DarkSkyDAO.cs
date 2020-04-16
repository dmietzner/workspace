using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ParkGeekAPI.Models;

namespace ParkGeekAPI.DAO
{
    public class DarkSkyDAO : IWeatherDAO
    {
        public List<Weather> GetForecast(Park park, string temperaturePreference)
        {
            double latitude = Park.coordinates[park.parkCode.ToUpper()][0];
            double longitude = Park.coordinates[park.parkCode.ToUpper()][1];
            Task<DarkSkyForecast> darkSkyForecast = Task.Run<DarkSkyForecast>(async () => await GetForecastAsync(latitude.ToString(), longitude.ToString()));
            List<Weather> result = new List<Weather>();
            int fiveDayForecastValue = 1;
            foreach (DarkSkyWeatherData item in darkSkyForecast.Result.daily.data)
            {
                Weather weather = new Weather(item,park.parkCode,temperaturePreference);
                weather.fiveDayForecastValue = fiveDayForecastValue++;
                result.Add(weather);
            }
            return result;
        }

        private async Task<DarkSkyForecast> GetForecastAsync(string latitude, string longitude)
        {
            // calling another server (dark sky) to get information
            string uriString = $"https://api.darksky.net/forecast/99b1f0333c4a1b2f581d0aed00c0260e/{latitude},{longitude}";
            DarkSkyForecast darkSkyForecast = new DarkSkyForecast();
            using (HttpClient client = new HttpClient())
            {
                Uri uri = new Uri(uriString);
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    darkSkyForecast = JsonConvert.DeserializeObject<DarkSkyForecast>(result);
                }
            }
            return darkSkyForecast;
        }
    }
}
