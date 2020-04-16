using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using Capstone.Classes;
using Capstone.DAL;

namespace Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the connection string from the appsettings.json file
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            string connectionString = configuration.GetConnectionString("Project");

            ICampgroundSqlDAO campgroundDAO = new CampgroundSqlDAO(connectionString);
            IParksSqlDAO parkDAO = new ParkSqlDAO(connectionString);
            IReservationSqlDAO reservationDAO = new ReservationSqlDAO(connectionString);
            ISiteSqlDAO siteDAO = new SiteSqlDAO(connectionString);


            NationalParksCLI nationalPark = new NationalParksCLI(parkDAO, campgroundDAO, reservationDAO, siteDAO);

            nationalPark.Run();
        }
    }
}
