using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace rabotenjeSoBaza.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string DonwlaudUrl { get; set; }
        public string ImageUrl { get; set; }
        public float reating { get; set; }
        public virtual List<Clint> clientList { get; set; }
        public Movie()
        {
            clientList = new List<Clint>();
        }
    }
}