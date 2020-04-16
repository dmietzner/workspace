using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Capstone.DAL
{
    public class ParkSqlDAO : IParksSqlDAO
    {
        private const string SQL_AllParks = "Select * from park order by name asc";
        private string ConnectionString;
        public ParkSqlDAO(string dbConnectionString)
        {
            ConnectionString = dbConnectionString;
        }
        public IList<Park> GetParks()
        {
            List<Park> parks = new List<Park>();

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SQL_AllParks, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Park e = GetParkFromReader(reader);
                            parks.Add(e);
                    }
                }
            } catch (SqlException ex)
            {
                throw;
            }
            return parks;
        }

        

        public Park GetParkFromReader(SqlDataReader reader)
        {
            Park e = new Park();
            e.Area = Convert.ToInt32(reader["area"]);
            e.Description = Convert.ToString(reader["description"]);
            e.Established = Convert.ToDateTime(reader["establish_date"]);
            e.Location = Convert.ToString(reader["location"]);
            e.Name = Convert.ToString(reader["name"]);
            e.ParkID = Convert.ToInt32(reader["park_id"]);
            e.Visitor = Convert.ToInt32(reader["visitors"]);

            return e;
        }

    }
}
