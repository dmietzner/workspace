using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using ParkGeekAPI.Models;

namespace ParkGeekAPI.DAO
{
    public class ParkDAO : IParkDAO
    {
        private string connectionString { get; }
        private IWeatherDAO weatherDAO { get; }
        public ParkDAO(string connectionString)
        {
            weatherDAO = new DarkSkyDAO();
            this.connectionString = connectionString;
        }

        public Park GetPark(string id, string temperaturePreference)
        {
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string cmd = "Select * from park where parkCode=@parkCode";
                        var result = conn.Query<Park>(cmd, new { parkCode = id }).FirstOrDefault();
                        result.weather = weatherDAO.GetForecast(result, temperaturePreference);
                        return result;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public List<Park> GetParks(string temperaturePreference)
        {
            List<Park> result = new List<Park>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string cmd = "select * from park";
                    var parkList = connection.Query<Park>(cmd).ToList();
                    // add weather to the parks
                    foreach (var park in parkList)
                    {
                        park.weather = weatherDAO.GetForecast(park, temperaturePreference);
                    }
                    
                    result = parkList;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
    }
}
