using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Capstone.DAL
{
   public interface ISiteSqlDAO
    {
        IList<Site> GetSiteInfo(int campId, DateTime start, DateTime end);

        Site ConvertReaderToSite(SqlDataReader reader);
    }
}
