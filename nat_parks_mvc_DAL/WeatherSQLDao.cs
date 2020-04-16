using Capstone.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Web.DAL
{
    public class WeatherSQLDao : IWeatherDao
    {
        private readonly string connectionString;

        public WeatherSQLDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Returns a list of all parks
        /// </summary>
        /// <returns></returns>
        /// 
        public IList<Weather> GetAllWeathers(string parkCode)
        {
            IList<Weather> weathers = new List<Weather>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * from weather where parkCode = @parkCode", conn);
                    cmd.Parameters.AddWithValue("@parkCode", parkCode);
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var weather = new Weather()
                        {
                            FiveDayForecastValue = Convert.ToInt32(reader["fiveDayForecastValue"]),
                            Low = Convert.ToInt32(reader["low"]),
                            High = Convert.ToInt32(reader["high"]),
                            Forecast = Convert.ToString(reader["forecast"]),


                        };

                        weathers.Add(weather);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return weathers;

        }

    }
}

