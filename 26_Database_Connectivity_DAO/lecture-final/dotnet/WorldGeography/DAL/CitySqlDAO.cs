﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class CitySqlDAO : ICityDAO
    {
        private string connectionString;

        /// <summary>
        /// Creates a new sql-based city dao.
        /// </summary>
        /// <param name="databaseconnectionString"></param>
        public CitySqlDAO(string databaseconnectionString)
        {
            connectionString = databaseconnectionString;
        }

        public int AddCity(City city)
        {
            int id = 0;
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    string commandText = "insert into city values(@name,@countrycode,@district,@population);select SCOPE_IDENTITY();";
                    cmd.CommandText = commandText;
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@name", city.Name);
                    cmd.Parameters.AddWithValue("@countrycode", city.CountryCode);
                    cmd.Parameters.AddWithValue("@district", city.District);
                    cmd.Parameters.AddWithValue("@population", city.Population);
                    id = Convert.ToInt32(cmd.ExecuteScalar());

                    commandText = "update country set capital=" + id + "where code='USA'";
                    cmd.CommandText = commandText;
                    cmd.ExecuteNonQuery();
                }
            } catch (SqlException e)
            {

            }
            return id;
        }

        public IList<City> GetCitiesByCountryCode(string countryCode)
        {
            List<City> cities = new List<City>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // column    // param name  
                    SqlCommand cmd = new SqlCommand("SELECT * FROM city WHERE countryCode = @countryCode;", conn);
                    // param name    // param value
                    cmd.Parameters.AddWithValue("@countryCode", countryCode);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        City city = ConvertReaderToCity(reader);
                        cities.Add(city);
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("An error occurred reading cities by country.");
                Console.WriteLine(ex.Message);
                throw;
            }

            return cities;
        }

        private City ConvertReaderToCity(SqlDataReader reader)
        {
            City city = new City();
            city.CityId = Convert.ToInt32(reader["id"]);
            city.Name = Convert.ToString(reader["name"]);
            city.CountryCode = Convert.ToString(reader["countrycode"]);
            city.District = Convert.ToString(reader["district"]);
            city.Population = Convert.ToInt32(reader["population"]);

            return city;
        }


    }
}