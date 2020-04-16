using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using WorldGeography.DAL;
using WorldGeography.Models;

namespace WorldGeographyTests.DAL
{
    [TestClass]
    public class LanguageDAOTests : WorldTestInitialize
    {
        [TestMethod]
        public void GetLanguageByNewCountryCode()
        {
            // Arrange
            LanguageSqlDAO languageSqlDAO = new LanguageSqlDAO(ConnectionString);

            // Act
            IList<Language> languages = languageSqlDAO.GetLanguages(newCountryCode);

            // Assert
            Assert.IsTrue(languages.Count > 0);
        }

        [DataTestMethod]
        [DataRow("USA",12)]
        [DataRow("XXX",0)]
        [DataRow("GBR",3)]


        public void GetLanguageBySpecificCountryCode(string countryCode, int expectedCount)
        {
            // Arrange
            LanguageSqlDAO languageSqlDAO = new LanguageSqlDAO(ConnectionString);

            // Act
            IList<Language> languages = languageSqlDAO.GetLanguages(countryCode);

            // Assert
            Assert.AreEqual(expectedCount, languages.Count);

        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void AddLanguageDuplicateTest()
        {
            // Arrange
            LanguageSqlDAO languageSqlDAO = new LanguageSqlDAO(ConnectionString);
            Language language = new Language
            {
                CountryCode = newCountryCode,
                Name = "Elvish",
                IsOfficial = true,
                Percentage = 5
            };

            // Assert 
            Assert.IsTrue(languageSqlDAO.AddNewLanguage(language));
            
        }
        [TestMethod]
        public void AddLanguageHappyTest()
        {
            // Arrange
            LanguageSqlDAO languageSqlDAO = new LanguageSqlDAO(ConnectionString);
            IList<Language> allLanguages = languageSqlDAO.GetLanguages(newCountryCode);
            foreach(Language foo in allLanguages)
            {
                if (foo.Name.Equals("Klingon"))
                {
                    Assert.IsTrue(false);
                }
            }
            Language language = new Language
            {
                CountryCode = newCountryCode,
                Name = "Klingon",
                IsOfficial = true,
                Percentage = 5
            };

            // Assert 
            Assert.IsTrue(languageSqlDAO.AddNewLanguage(language));
            
        }
    }
}
