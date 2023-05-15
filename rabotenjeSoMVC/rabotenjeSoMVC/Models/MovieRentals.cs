using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rabotenjeSoMVC.Models
{
    public class MovieRentals
    {
        public Movie movie { get; set; }
        public List<Clint> clintsList { get; set; }

        public MovieRentals()
        {
            clintsList = new List<Clint>();
        }
    }
}