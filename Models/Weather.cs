using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Web.Models
{
    public class Weather
    {
        public string ParkCode { get; set; }
        public int FiveDayForecastValue { get; set; }
        public int Low { get; set; }
        public int High { get; set; }
        public string Forecast { get; set; }
        public string DisplayWeatherImage(string forecast)
        {
            string weatherImgUrl = "/images/weather/";
            if (forecast == "cloudy")
            {
                weatherImgUrl += "cloudy.png";
            }
            else if (forecast == "partly cloudy")
            {
                weatherImgUrl += "partlyCloudy.png";   
            }
            else if (forecast == "rain")
            {
                weatherImgUrl += "rain.png";
            }
            else if (forecast == "snow")
            {
                weatherImgUrl += "snow.png";
            }
            else if (forecast == "sunny")
            {
                weatherImgUrl += "sunny.png";
            }
            else if (forecast == "thunderstorms")
            {
                weatherImgUrl += "thunderstorms.png";               
            }
            return weatherImgUrl;
        }
        public double ConvertToSelectedScale(int tempInF, string tempScale)
        {
            double displayTemp = tempInF;
            if (tempScale == "C")
            {
                displayTemp = (tempInF - 32) / 1.8;
            }
            return displayTemp;                
        }
        public List<string> CreateForecastMessageList(Weather weather)
        {
            List<string> forecastMessages = new List<string>();
            if (weather.Forecast == "snow")
            {
                forecastMessages.Add("It's snowy out there! Don't forget your snow shoes!");
            }
            if (weather.Forecast == "rain")
            {
                forecastMessages.Add("It's raining cats and dogs!  Pack your rain gear and waterproof shoes!");
            }
            if (weather.Forecast == "thunderstorms")
            {
                forecastMessages.Add("Storms a-brewin', seek shelter and avoid exposed ridges!");
            }
            if (weather.Forecast == "sunny")
            {
                forecastMessages.Add("Blue skies today! Pack sunblock!");
            }
            if (weather.High > 75)
            {
                forecastMessages.Add("Remember to bring an extra gallon water today.");
            }
            if (weather.High - weather.Low > 20)
            {
                forecastMessages.Add("Wear breathable clothing today to help with temperature swings.");
            }
            if (weather.Low < 20)
            {
                forecastMessages.Add("It's freezing out there, beware of exposure to today's low temperatures!");
            }
            return forecastMessages;
        }

    }
}
