using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Web.Models
{
    public class SurveyViewModel
    {
        [Display(Name = "Favorite National Park")]
        [Required(ErrorMessage = "* Please select a favorite national park.")]
        public string ParkCode { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter an email")]
        [StringLength(100, ErrorMessage = "* The length of the email can not be more than 100 characters")]
        public string EmailAddress { get; set; }

        [Display(Name = "State of Residence")]
        [Required(ErrorMessage = "* Please provide your state of residence.")]
        public string State { get; set; }

        [Required(ErrorMessage = "* Please select an activity level.")]
        public string ActivityLevel { get; set; }
    }
}
