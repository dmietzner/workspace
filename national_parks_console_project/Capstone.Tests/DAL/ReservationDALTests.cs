using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Models;
using Capstone.DAL;


namespace Capstone.Tests.DAL
{
    [TestClass]
    public class ReservationDALTests : npcampgroundTestInitialize
    {
        //    [TestMethod]
        //    public void BookReservation_Happy()
        //    {
        //        ReservationSqlDAO dao = new ReservationSqlDAO(ConnectionString);
        //        IList<Reservation> reservations = dao.GetAllReservation();
        //        foreach (Reservation reservation in reservations)
        //        {
        //            if (reservation.Name.Equals("testreservation"))
        //            {
        //                Assert.IsTrue(false);
        //            }
        //        }
        //        Reservation newReservation = new Reservation
        //        {
        //            SiteId = 1,
        //            Name = "testreservation",
        //            StartDate = (2020, 10, 17),
        //            EndDate = (2020, 10, 21),
        //            Create = (2020, 02, 26) --I was unable to pass on this test as I could not plug in test values for these DateTime types properly.





        //        };
        //        Assert.IsTrue(dao.BookReservation(newReservation) > 0);
        //    }
    }
}
