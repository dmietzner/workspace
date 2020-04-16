using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldGeography.DAL;

namespace WorldGeography
{
    class Program
    {
        static void Main(string[] args)
        {

            ICityDAO cityDAO = new CitySqlDAO(@"Server=.\SQLEXPRESS;Database=World;Trusted_Connection=True;");
            ICountryDAO countryDAO = new CountrySqlDAO(@"Server=.\SQLExpress;Database=World;Trusted_Connection=True;");
            ILanguageDAO languageDAO = new LanguageSqlDAO(@"Server=.\SQLEXPRESS;Database=World;Trusted_Connection=True;");

            WorldGeographyCLI cli = new WorldGeographyCLI(cityDAO, countryDAO, languageDAO);
            cli.RunCLI();
        }
    }
}
