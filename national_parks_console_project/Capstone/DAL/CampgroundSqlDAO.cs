using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Capstone.DAL
{
    public class CampgroundSqlDAO : ICampgroundSqlDAO

    {
        private const string SQL_AllCampgrounds = "Select * from campground order by name asc";
        private string ConnectionString;
        public CampgroundSqlDAO(string dbConnectionString)
        {
            ConnectionString = dbConnectionString;
        }

        public IList<Campground> GetCampgrounds(int parkId)
        {
            List<Campground> campgrounds = new List<Campground>();

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand($"Select * from campground where park_id = {parkId} order by name asc", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Campground e = GetCampgroundFromReader(reader);
                        campgrounds.Add(e);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return campgrounds;
        }

        public Campground GetCampgroundFromReader(SqlDataReader reader)
        {
            {
                Campground e = new Campground();
                e.CampId = Convert.ToInt32(reader["campground_id"]);
                e.ParkId = Convert.ToInt32(reader["park_id"]);
                e.Open = Convert.ToInt32(reader["open_from_mm"]);
                e.Close = Convert.ToInt32(reader["open_to_mm"]);
                e.Name = Convert.ToString(reader["name"]);
                e.DailyFee = Convert.ToDecimal(reader["daily_fee"]);
                return e;
            }
        }
    }
}
