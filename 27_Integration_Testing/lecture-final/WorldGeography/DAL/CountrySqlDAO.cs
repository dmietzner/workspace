using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class CountrySqlDAO : ICountryDAO
    {
        private string connectionString;

        /// <summary>
        /// Creates a sql based country dao.
        /// </summary>
        /// <param name="databaseconnectionString"></param>
        public CountrySqlDAO(string databaseconnectionString)
        {
            connectionString = databaseconnectionString;
        }        
        
        public IList<Country> GetCountries()
        {

            // Declare the output variable for return
            List<Country> countries = new List<Country>();

            // Let's do the database stuff
            try
            {
                // 1 Create a connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // 2 Open the connection
                    connection.Open();

                    // 3 Create a command object
                    SqlCommand cmd = new SqlCommand();

                    // 4 Set the command string
                    string command = "Select * from country;";
                    cmd.CommandText = command;

                    // 5 Set the connection object
                    cmd.Connection = connection;

                    // 6 Get the data
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Read each row
                    while(reader.Read())
                    {
                        Country country = new Country();
                        country = ConvertReaderToCountry(reader);

                        countries.Add(country);
                    }
                    // Close the connection via the using statement
                }
            } catch(Exception e)
            {
                Console.WriteLine("An error occurred communicating with the database. ");
                Console.WriteLine(e.Message);
                throw;

            }
            // Send back the output
            return countries;
        }

        public IList<Country> GetCountries(string continent)
        {
            List<Country> countries = new List<Country>();

            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                string sqlText = "select * from country where continent= @continent";
                cmd.CommandText = sqlText;
                cmd.Parameters.AddWithValue("@continent", continent);
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Country country = ConvertReaderToCountry(reader);
                    countries.Add(country);
                }
                // Since no using statement, must manually close
                conn.Close();
            } catch(SqlException sqlEx)
            {
                Console.WriteLine("An error occurred reading countries by continent.");
                Console.WriteLine(sqlEx.Message);
                throw;

            }
            catch (Exception e)
            {

            }

            return countries;
        }

        /// <summary>
        /// Little helper function to convert reader to country.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private Country ConvertReaderToCountry(SqlDataReader reader)
        {
            Country country = new Country();
            country.Code = Convert.ToString(reader["code"]);
            country.Name = Convert.ToString(reader["name"]);
            country.Continent = Convert.ToString(reader["continent"]);
            country.Region = Convert.ToString(reader["region"]);
            country.SurfaceArea = Convert.ToDouble(reader["surfacearea"]);
            country.Population = Convert.ToInt32(reader["population"]);
            country.GovernmentForm = Convert.ToString(reader["governmentform"]);
            return country;

        }
    }
}
