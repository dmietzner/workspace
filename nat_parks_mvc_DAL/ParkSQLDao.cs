using Capstone.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Web.DAL
{
    public class ParkSQLDao : IParkDao
    {

        private readonly string connectionString;

        public ParkSQLDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Returns a list of all parks
        /// </summary>
        /// <returns></returns>
        public IList<Park> GetAllParks()
        {
            IList<Park> parks = new List<Park>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * from park ", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Park park = new Park();
                        park = ConvertReaderToPark(reader); 
                        parks.Add(park);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return parks;
        }

        public Park GetSelectedPark(string parkCode)
        {
            Park park = new Park();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * from park WHERE parkCode = @parkCode;");
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@parkCode", parkCode);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        park = ConvertReaderToPark(reader);
                    }
                }
            } catch (Exception e)
            {
                throw;
            }
            return park;
        }

        private Park ConvertReaderToPark(SqlDataReader reader)
        {
            Park park = new Park();
            park.ParkCode = Convert.ToString(reader["parkCode"]);
            park.ParkName = Convert.ToString(reader["parkName"]);
            park.State = Convert.ToString(reader["state"]);
            park.Acreage = Convert.ToInt32(reader["acreage"]);
            park.ElevationInFeet = Convert.ToInt32(reader["elevationInFeet"]);
            park.MilesOfTrail = float.Parse(Convert.ToString(reader["milesOfTrail"]));
            park.NumberOfCampsites = Convert.ToInt32(reader["numberofCampsites"]);
            park.Climate = Convert.ToString(reader["climate"]);
            park.YearFounded = Convert.ToInt32(reader["yearFounded"]);
            park.AnnualVisitorCount = Convert.ToInt32(reader["annualVisitorCount"]);
            park.InspirationalQuote = Convert.ToString(reader["inspirationalQuote"]);
            park.InspirationalQuoteSource = Convert.ToString(reader["inspirationalQuoteSource"]);
            park.ParkDescription = Convert.ToString(reader["parkDescription"]);
            park.EntryFee = Convert.ToInt32(reader["entryFee"]);
            park.NumberOfAnimalSpecies = Convert.ToInt32(reader["numberofAnimalSpecies"]);
            return park;
        }
    }
}
