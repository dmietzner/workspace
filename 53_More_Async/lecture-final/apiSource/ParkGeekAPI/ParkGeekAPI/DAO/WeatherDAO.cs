using Dapper;
using ParkGeekAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ParkGeekAPI.DAO
{
    public class WeatherDAO : IWeatherDAO
    {
        private string connectionString { get; }
        public WeatherDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Weather> GetForecast(Park park, string temperaturePreference)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string cmd = "Select * from weather where parkCode=@parkCode";
                    var result = conn.Query<Weather>(cmd, new { parkCode = park.parkCode }).ToList();
                    foreach (var item in result)
                    {
                        item.temperaturePreference = temperaturePreference;
                    }
                    return result;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
