using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Models;
using Capstone.Classes;
using Capstone.DAL;
using System.Globalization;

namespace Capstone.Classes
{
    public class NationalParksCLI
    {
        private string parkInformationInput = "";
        private string mainMenuInput = "";
        private string campgroundInput = "";
        private DateTime searchDateArrival { get; set; }
        private DateTime searchDateDeparture { get; set; }
        private string searchDateArrivalInput { get; set; }
        private string searchDateDepartureInput { get; set; }
        private string siteInput { get; set; }
        private string nameInput { get; set; }



        private const string Option_ListAllParks = "1";
        private const string Option_Quit = "q";
        private const string Option_ListAllCampgrounds = "1";
        private const string Option_PreviousScreenParkInfo = "3";


        private IParksSqlDAO parkDAO;
        private ICampgroundSqlDAO campgroundDAO;
        private ISiteSqlDAO siteDAO;
        private IReservationSqlDAO reservationDAO;

        private int ParkIndex { get; set; }
        private int CampgroundIndex { get; set; }

        public NationalParksCLI(IParksSqlDAO parkDAO, ICampgroundSqlDAO campgroundDAO, IReservationSqlDAO reservationDAO, ISiteSqlDAO siteDAO)
        {
            this.parkDAO = parkDAO;
            this.campgroundDAO = campgroundDAO;
            this.reservationDAO = reservationDAO;
            this.siteDAO = siteDAO;
        }
        public void Run()
        {


            while (true)
            {
                Console.Clear();
                PrintTitle();
                Console.WriteLine();
                DisplayMainMenu();
                mainMenuInput = Console.ReadLine().ToLower().Trim('u', 'i', 't');
                switch (mainMenuInput)
                {
                    case Option_ListAllParks:
                        Console.Clear();
                        GetAllParks();
                        break;

                    case Option_Quit:
                        Console.WriteLine("Thank you for using the National Park Reservation System");
                        Environment.Exit(0);
                        break;

                }
            }
        }
        private void PrintTitle()
        {
            Console.WriteLine("National Park Reservation System");
        }

        private void DisplayMainMenu()
        {
            Console.WriteLine("Please select an option");
            Console.WriteLine("1.) List all registered parks");
            Console.WriteLine("Q.) Quit application");



        }

        private void GetAllParks()
        {

            IList<Park> parks = parkDAO.GetParks();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Registered national parks:");



                if (parks.Count > 0)
                {
                    int i = 0;
                    Console.WriteLine("Please select a park");
                    for (i = 0; i < parks.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}.) {parks[i].Name}");
                    }

                    Console.WriteLine($"{i + 1}.) Return to previous screen");

                    Console.WriteLine();
                    try
                    {
                        ParkIndex = Convert.ToInt32(Console.ReadLine());
                        if (ParkIndex == parks.Count + 1)
                        {
                            return;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Please enter a valid park number");
                    }

                    DisplayParkInformation();


                }
                else
                {
                    Console.WriteLine("No parks in registry");
                    Console.WriteLine();
                }
            }
        }

        private void DisplayParkInformation()
        {
            IList<Park> parks = parkDAO.GetParks();

            try
            {
                Console.Clear();
                Console.WriteLine("Park information:");
                Console.WriteLine(parks[ParkIndex - 1].Name);
                Console.WriteLine("Location:".PadRight(20) + parks[ParkIndex - 1].Location);
                Console.WriteLine("Established:".PadRight(20) + parks[ParkIndex - 1].Established.ToString("MM/dd/yyyy"));
                Console.WriteLine("Area:".PadRight(20) + parks[ParkIndex - 1].Area.ToString("N0") + " sq km");
                Console.WriteLine("Annual visitors:".PadRight(20) + parks[ParkIndex - 1].Visitor.ToString("N0"));
                Console.WriteLine();
                Console.WriteLine(parks[ParkIndex - 1].Description);
                Console.WriteLine();


                DisplayParkInformationMenu(parks[ParkIndex - 1]);
            }

            catch (Exception e)
            {
                Console.WriteLine("Please enter a valid command");
            }


        }

        private void DisplayParkInformationMenu(Park park)
        {
            Console.WriteLine();
            Console.WriteLine("1.) See available campgrounds for this park");
            Console.WriteLine("2.) Select another park");
            parkInformationInput = Console.ReadLine();
            switch (parkInformationInput)
            {
                case Option_ListAllCampgrounds:
                    GetAllCampgrounds(park);
                    break;

                case Option_PreviousScreenParkInfo:
                    break;
            }
        }

        private void GetAllCampgrounds(Park park)
        {
            IList<Campground> campgrounds = campgroundDAO.GetCampgrounds(park.ParkID);

            while (true)
            {
                Console.WriteLine();
                CampgroundIndex = 0;

                Console.WriteLine("Registered campgrounds");

                if (campgrounds.Count > 0)
                {
                    Console.WriteLine("Please select a campground");
                    Console.WriteLine("          Name".PadRight(50) + "Open".PadRight(15) + "Close".PadRight(15) + "Daily Fee");
                    for (int i = 0; i < campgrounds.Count; i++)
                    {

                        Console.WriteLine($"{CampgroundIndex + 1}.)".PadRight(10) + campgrounds[CampgroundIndex].Name.PadRight(40) + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(campgrounds[CampgroundIndex].Open).PadRight(15) + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(campgrounds[CampgroundIndex].Close).PadRight(15) + campgrounds[CampgroundIndex].DailyFee.ToString("C2"));
                        CampgroundIndex++;
                    }
                    Console.WriteLine($"{CampgroundIndex + 1}.) Select another park");


                    SelectCampground(campgrounds);
                    break;

                }
                else
                {
                    Console.WriteLine("No campgrounds in registry for this park");

                }


            }
        }

        private void SelectCampground(IList<Campground> campgrounds)
        {
            Console.WriteLine();
            try
            {
                campgroundInput = Console.ReadLine();
                int cgIndex = Convert.ToInt32(campgroundInput) - 1;
                if (cgIndex + 1 == CampgroundIndex + 1)
                {
                    return;
                }
                bool foundCampGround = false;
                foreach (Campground campground in campgrounds)
                {
                    if (campgrounds[cgIndex].CampId == campground.CampId)
                    {
                        foundCampGround = true;
                        try
                        {
                            int result = 0;
                            Console.WriteLine();
                            Console.WriteLine("When is the arrival date? mm/dd/yyyy (Enter 0 to change parks)");
                            searchDateArrivalInput = Console.ReadLine();
                            if (Int32.TryParse(searchDateArrivalInput, out result))
                            {
                                return;
                            } else
                            {
                                searchDateArrival = Convert.ToDateTime(searchDateArrivalInput);
                            }
                            Console.WriteLine();
                            Console.WriteLine("When is the departure date? mm/dd/yyyy (Enter 0 to change parks)");
                            searchDateDepartureInput = Console.ReadLine();
                            if (Int32.TryParse(searchDateDepartureInput, out result))
                            {
                                return;
                            }
                            else
                            {
                                searchDateDeparture = Convert.ToDateTime(searchDateDepartureInput);
                            }
                            break;

                            


                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Please enter dates in the valid given format");
                        }
                    }
                }
                if (!foundCampGround)
                {
                    Console.WriteLine("Please enter a valid campground");
                    return;
                } else
                {
                    DisplayAllSites(campgrounds[cgIndex]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter a valid campground");
            }


        }

        private void DisplayAllSites(Campground campground)
        {
            IList<Site> sites = siteDAO.GetSiteInfo(campground.CampId, searchDateArrival, searchDateDeparture);
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Results matching your search criteria:");

                string isAccessible = "";
                string availableUtilities = "";
                string rvLength = "";
                int index = 0;

                if (sites.Count > 0)
                {

                    Console.WriteLine("Site No.".PadLeft(15).PadRight(20) + "Max Occup.".PadRight(15) + "Accessible?".PadRight(15) + "Max RV Length".PadRight(20) + "Utility".PadRight(15) + "Cost"); ;
                    for (int i = 0; i < sites.Count; i++)
                    {
                        index = i;
                        if (sites[i].Accessible == true)
                        {
                            isAccessible = "Yes";
                        } else
                        {
                            isAccessible = "No";
                        }
                        if (sites[i].Utilities == true)
                        {
                            availableUtilities = "Yes";
                        }
                        else
                        {
                            availableUtilities = "N/A";
                        }
                        if (sites[i].MaxLengthRv == 0)
                        {
                            rvLength = "N/A";
                        }
                        else
                        {
                            rvLength = sites[i].MaxLengthRv.ToString();
                        }
                        Console.WriteLine((index + 1) + ".)".PadRight(10) +  sites[i].SiteNum.ToString().PadRight(15) + sites[i].MaxOccupancy.ToString().PadRight(15) + isAccessible.PadRight(15) + rvLength.PadRight(20) + availableUtilities.PadRight(15) + campground.DailyFee.ToString("C2"));
                    }
                   


                    DisplaySiteMenu();
                    Console.WriteLine($"** Thank you for using the National Park Reservation System. Your reservation id number is {reservationDAO.BookReservation(MakeReservation(sites[Convert.ToInt32(siteInput) -1 ]))} **");
                    Environment.Exit(0);


                }
                else 
                {
                    Console.WriteLine("No sites in registry available for the given date");
                    break;
                }
            }
        }

        private void DisplaySiteMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Which site should be reserved? (enter 0 to cancel)");
            siteInput = Console.ReadLine();
            switch (siteInput)
            {
                case "0":
                    return;

            }

            Console.WriteLine();
            Console.WriteLine("What name should the reservation be made under?");
            nameInput = Console.ReadLine();
            Console.WriteLine();

        }

        private Reservation MakeReservation(Site site)
        {
            Reservation reservation = new Reservation();

            reservation.Create = DateTime.Now;
            reservation.EndDate = searchDateDeparture;
            reservation.Name = nameInput;
            reservation.SiteId = site.SiteId;
            reservation.StartDate = searchDateArrival;
            return reservation;
        }
        


    }
}
