using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Capstone.DAL
{
    public interface IReservationSqlDAO
    {
        Reservation ConvertReaderToReservation(SqlDataReader reader);

        int BookReservation(Reservation newReservation);
    }
}
