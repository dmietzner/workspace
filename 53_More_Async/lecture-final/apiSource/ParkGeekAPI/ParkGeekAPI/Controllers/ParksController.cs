using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkGeekAPI.DAO;
using ParkGeekAPI.Models;

namespace ParkGeekAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class ParksController : ControllerBase
    {
        private IParkDAO parkDAO { get; }
        private IWeatherDAO weatherDAO { get; }
        public ParksController(IParkDAO parkDAO, IWeatherDAO weatherDAO)
        {
            this.parkDAO = parkDAO;
            this.weatherDAO = weatherDAO;
        }

        [HttpGet]
        public List<Park> Get()
        {
            
            return parkDAO.GetParks(getTempCookie());
        }

        [HttpGet("{id}", Name = "Get")]
        public Park GetAsync(string id)
        {
            return parkDAO.GetPark(id, getTempCookie());
        }

        [HttpGet("{id}/weather")]
        public List<Weather> GetWeather(string id)
        {
            return weatherDAO.GetForecast(parkDAO.GetPark(id, getTempCookie()), getTempCookie());
        }

        [HttpGet("{id}/weather/temp")]
        public List<Park> SetTempPref(string id)
        {
            string tempPref = getTempCookie();
            if(tempPref == "F")
            {
                tempPref = "C";
            } else
            {
                tempPref = "F";
            }

            setTempCookie(tempPref);
            return parkDAO.GetParks(tempPref);
        }
        private string getTempCookie()
        {
            string cookieTempPref = HttpContext.Request.Cookies["tempPreference"];
            if (string.IsNullOrEmpty(cookieTempPref))
            {
                cookieTempPref = "F";
            }
            return cookieTempPref;
        }

        private void setTempCookie(string temp)
        {
            CookieOptions option = new CookieOptions();
            option.Expires = DateTime.UtcNow.AddDays(7);
            option.IsEssential = true;
            HttpContext.Response.Cookies.Append("tempPreference", temp,option);
        }
    }
}