using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace Capstone.DAL
{

    public class SiteSqlDAO : ISiteSqlDAO
    {
        private string connectionString;
        public SiteSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public IList<Site> GetSiteInfo(int campId, DateTime start, DateTime end)
        {
            List<Site> sites = new List<Site>();
            try
            {
                //this is the search/get info method. I had to join into campground to get the dailyfee collumns. We will need the user input for the camp_id, and (start/end date which we will use in our BookReservation() method).
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    string command = @"select site.site_id, site_number, max_occupancy, accessible, max_rv_length, utilities, site.campground_id, campground.daily_fee from site
                                     join campground on site.campground_id = campground.campground_id
                                     where campground.campground_id = @campId and site_id not in(
                                     select site.site_id
                                     from site
                                     join campground on site.campground_id = campground.campground_id
                                     join reservation on site.site_id = reservation.site_id
                                     where
                                     site.campground_id = @campId and
                                     (
                                     @start between from_date and to_date or
                                     @end between from_date and to_date or
                                     (
                                     @start < from_date and @end > to_date
                                     )))";

                    cmd.Parameters.AddWithValue("@start", start);
                    cmd.Parameters.AddWithValue("@end", end);
                    cmd.Parameters.AddWithValue("@campId", campId);
                    cmd.CommandText = command;
                    cmd.Connection = connection;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                       
                        Site site = ConvertReaderToSite(reader);
                        sites.Add(site);
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return sites;
        }
        public Site ConvertReaderToSite(SqlDataReader reader)
        {
            Site site = new Site();
            site.CampId = Convert.ToInt32(reader["campground_id"]);
            site.SiteNum = Convert.ToInt32(reader["site_number"]);
            site.MaxOccupancy = Convert.ToInt32(reader["max_occupancy"]);
            site.Accessible = Convert.ToBoolean(reader["accessible"]);
            site.MaxLengthRv = Convert.ToInt32(reader["max_rv_length"]);
            site.Utilities = Convert.ToBoolean(reader["utilities"]);
            site.SiteId = Convert.ToInt32(reader["site_id"]);

            return site;
        }
    }
    }
