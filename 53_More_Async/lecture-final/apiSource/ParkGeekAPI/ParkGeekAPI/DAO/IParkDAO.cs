using ParkGeekAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkGeekAPI.DAO
{
    public interface IParkDAO
    {
        List<Park> GetParks(string temperaturePreference);
        Park GetPark(string id, string temperaturePreference);
    }
}
