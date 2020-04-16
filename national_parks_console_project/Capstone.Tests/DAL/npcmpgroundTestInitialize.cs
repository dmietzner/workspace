using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using System.Data.SqlClient;

namespace Capstone.Tests
{
    [TestClass]
    public class npcampgroundTestInitialize
    {
        protected TransactionScope transaction;
        protected string ConnectionString
        {
            get
            {
                return "Server=STUDENT-ASUS-0\\SQLEXPRESS;Database=npcampground;Trusted_Connection=True;";
            }
        }
        protected int numPark = 0;
        protected int numCamp = 0;
        protected int numReservation = 0;
        protected int numSite = 0;


        [TestInitialize]
        public void Setup()
        {

            transaction = new TransactionScope();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand($"SELECT COUNT(*) FROM park WHERE name = 'testpark'", connection);

                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) == 0)
                {
                    sqlCommand = new SqlCommand($"INSERT INTO park values('testpark','testland', '1920-01-01', 500, 1, 'testing')", connection);
                    sqlCommand.ExecuteNonQuery();
                }
                sqlCommand = new SqlCommand($"SELECT COUNT(*) FROM reservation WHERE name = 'testreservation'", connection);

                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) == 0)
                {
                    sqlCommand = new SqlCommand($"INSERT INTO reservation values( 1, 'testreservation', '2020-10-17', '2020-10-21', GetDate())", connection);
                    sqlCommand.ExecuteNonQuery();
                }

                sqlCommand = new SqlCommand("select count(*) from park", connection);
                numPark = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlCommand = new SqlCommand("select count(*) from campground", connection);
                numCamp = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlCommand = new SqlCommand("select count(*) from reservation", connection);
                numReservation = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlCommand = new SqlCommand("select count(*) from site", connection);
                numSite = Convert.ToInt32(sqlCommand.ExecuteScalar());
            }

        }
        [TestCleanup]
        public void Cleanup()
        {
            transaction.Dispose();
        }

    }
}

