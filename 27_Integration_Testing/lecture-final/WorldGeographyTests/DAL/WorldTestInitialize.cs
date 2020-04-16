using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Transactions;

namespace WorldGeographyTests.DAL
{
    [TestClass]
    public class WorldTestInitialize
    {
        protected TransactionScope transaction;
        protected string ConnectionString
        {
            get
            {
                return "Server=.\\SQLEXPRESS;Database=World;Trusted_Connection=True;";
            }
        }
        protected int numCountries = 0;
        protected const string newCountryCode = "YYZ";

        [TestInitialize]
        public void Setup()
        {
            // Begins the transaction
            transaction = new TransactionScope();


            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand($"select count(*) from country where code='{newCountryCode}'", connection);
                // Let's check the result to see if it is the database
                if (Convert.ToInt32(sqlCommand.ExecuteScalar()) == 0)
                {
                    sqlCommand = new SqlCommand($"insert into country Values('{newCountryCode}','Tech Elevator','North America','Southern States',6,7,2,2,2,2,'Here','Dictatorship','Justin Driscoll',null,'AB');insert into countrylanguage values('{newCountryCode}','Elvish',0,5);", connection);
                    sqlCommand.ExecuteNonQuery();
                }
                else
                {
                    // Insert a language for our country
                    try
                    {
                        // If it errors, it is there, if not it is inserted
                        sqlCommand = new SqlCommand($"insert into countrylanguage Values('{newCountryCode}','Elvish',0,5)", connection);
                        sqlCommand.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {

                    }
                }



                sqlCommand = new SqlCommand("select count(*) from country", connection);
                numCountries = Convert.ToInt32(sqlCommand.ExecuteScalar());

            }
        }
        [TestCleanup]
        public void CleanUp()
        {
            transaction.Dispose();
        }


    }
}
