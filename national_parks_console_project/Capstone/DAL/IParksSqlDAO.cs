using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Capstone.Models;

namespace Capstone.DAL
{
    public interface IParksSqlDAO
    {
        IList<Park> GetParks();

        Park GetParkFromReader(SqlDataReader reader);
        
        
    
    
    }
}
