using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Transactions;
using WorldGeography.DAL;
using WorldGeography.Models;

namespace WorldGeographyTests.DAL
{
    [TestClass]
    public class CountryDAOTests : WorldTestInitialize
    {


        [TestMethod]
        public void GetCountriesTest_Should_ReturnAllCountries()
        {
            // Arrange
            CountrySqlDAO dao = new CountrySqlDAO(ConnectionString);

            // Act
            IList<Country> countries = dao.GetCountries();

            // Assert
            Assert.AreEqual(numCountries, countries.Count);
            // Some will argue this is sufficient
            Assert.IsTrue(countries.Count > 0);
        }

        [TestMethod]
        public void GetCountriesInNorthAmericaTest()
        {
            // Arrange
            CountrySqlDAO countrySqlDAO = new CountrySqlDAO(ConnectionString);

            // Act
            IList<Country> countries = countrySqlDAO.GetCountries("North America");

            // Assert
            Assert.IsTrue(countries.Count > 0);
        }
    }
}
