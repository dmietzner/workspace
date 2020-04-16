using ParkGeekAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkGeekAPI.DAO
{
    public interface IWeatherDAO
    {
        List<Weather> GetForecast(Park park, string temperaturePreference);

    }
}
