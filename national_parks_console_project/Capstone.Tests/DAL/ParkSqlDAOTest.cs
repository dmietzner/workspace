using Capstone.DAL;
using Capstone.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Tests
{
    [TestClass]
   public class ParkSqlDAOTest :npcampgroundTestInitialize
    {
        [TestMethod]
        public void GetParksTest()
        {
            ParkSqlDAO dao = new ParkSqlDAO(ConnectionString);
            IList<Park> parks = dao.GetParks();
            Assert.IsTrue(parks.Count > 0);

        }

    }
}
