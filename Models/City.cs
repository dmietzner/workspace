using Forms.Web.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Forms.Web.Models
{
    public class City
    {
        public int CityId { get;  set; }
        [Required(ErrorMessage ="Please enter the name of your city")]
        [StringLength(10,ErrorMessage ="The name of the city can't be more than 10 characters. Sorry, our database person was lazy")]
        public string Name { get;  set; }
        [Required]
        [CountryCode]
        public string CountryCode { get;  set; }
        [Required(ErrorMessage ="*")]
        public string District { get;  set; }
        [Required(ErrorMessage = "Please enter a population in millions")]
        public int Population { get;  set; }
    }

    public class CountryCodeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            CitySqlDAO citySqlDAO = new CitySqlDAO(@"Data Source=.\SQLEXPRESS;Initial Catalog=World;Integrated Security=True");
            List<string> countryCodes = citySqlDAO.GetCountryCodes().ToList();
            City city = (City)validationContext.ObjectInstance;

            if(!countryCodes.Contains(city.CountryCode))
            {
                return new ValidationResult("Country Code does not exist. Please try again.");
            }
            return ValidationResult.Success;

        }
    }
}
