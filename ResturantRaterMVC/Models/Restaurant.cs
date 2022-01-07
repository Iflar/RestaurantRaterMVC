using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ResturantRaterMVC.Models
{
    public class Restaurant
    {
        public int RestaurantID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int Rating { get; set; }
        
    }

    public class RestaurantDbContex : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}