﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Models
{
    public class Reservation
    {
        public int ResId { get; set; }

        public int SiteId { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime Create { get; set; }


    }
}
