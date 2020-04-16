using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Models;
using System.Data.SqlClient;

namespace Capstone.DAL
{
   public class ReservationSqlDAO : IReservationSqlDAO
    {
        private string connectionString;

        public ReservationSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

       
        public IList<Reservation> GetAllReservation() //this method I thought would be important to testing the BookReservation() method 
                                                     //but I was unable to get the BookReservation test to work.
        {
            List<Reservation> reservations = new List<Reservation>();
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    string command = "Select * from reservation";
                    cmd.CommandText = command;
                    cmd.Connection = connection;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Reservation reservation = new Reservation();
                        reservation = ConvertReaderToReservation(reader);
                        reservations.Add(reservation);
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return reservations;
        }

        //We should be deleting this method. I created a method in the SiteSqlDAO that 1. searches for avaialable reservations given the site_id, start, end date. It is called GetSiteInfo(), we can rename it as needed.
        //{
        //public IList<Reservation> SearchReservation(int siteId) 
        //    List<Reservation> reservations = new List<Reservation>();
        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            connection.Open();
        //            SqlCommand cmd = new SqlCommand();
        //            cmd.CommandText = ("Select * from reservation where campground_id = @campground_id)");
        //            cmd.Parameters.AddWithValue("@siteId", siteId);
        //            cmd.Connection = connection;
        //            SqlDataReader reader = cmd.ExecuteReader();
        //            while (reader.Read())
        //            {
        //                Reservation reservation = new Reservation();
        //                reservation = ConvertReaderToReservation(reader);
        //                reservations.Add(reservation);
        //            }

        //        }

        //    } catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    return reservations;
        //}

        public int BookReservation(Reservation newReservation) //This method shouldnt be too hard to fit in at the end. The start/end dates will be given already by the user we only need user to enter the site_id and the name for reservation.
        {
            int id = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO reservation values (@site_id, @name ,@start ,@end ,GetDate()); select SCOPE_IDENTITY();", connection);
                    cmd.Parameters.AddWithValue("@site_id", newReservation.SiteId);
                    cmd.Parameters.AddWithValue("@name", newReservation.Name);
                    cmd.Parameters.AddWithValue("@start", newReservation.StartDate);
                    cmd.Parameters.AddWithValue("@end", newReservation.EndDate);
                    id = Convert.ToInt32(cmd.ExecuteScalar());


                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            return id;
        }

   

        public Reservation ConvertReaderToReservation(SqlDataReader reader)
        {
            Reservation reservation = new Reservation();
            reservation.ResId = Convert.ToInt32(reader["reservation_id"]);
            reservation.SiteId = Convert.ToInt32(reader["site_id"]);
            reservation.Name = Convert.ToString(reader["name"]);
            reservation.StartDate = Convert.ToDateTime(reader["from_date"]);
            reservation.EndDate = Convert.ToDateTime(reader["to_date"]);
            reservation.Create = Convert.ToDateTime(reader["create_date"]);
            return reservation;
        }



    }
}
