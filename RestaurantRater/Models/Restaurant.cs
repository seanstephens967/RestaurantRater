using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantRater.Models
{
    public class Restaurant
    {
        public int RestaurantID { get; set; }
        public int Name { get; set; }
        public int Address { get; set; }
        public int Rating { get; set; }
    }
}