using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Post.Web.Models
{
    public class Review

    {
        
        [Display(Name = "User Name" )]
        public string UserName { get; set; }
        [Display(Name = "How Many Stars?")]
        public int Rating { get; set;}
        [Display(Name = "Provide a Title")]
        public string Title { get; set;}
        [Display(Name = "Review")]
        public string Text { get; set;}
        
        public DateTime ReviewDate { get; set; }

        public int ReviewId { get; set; }

    }

}
