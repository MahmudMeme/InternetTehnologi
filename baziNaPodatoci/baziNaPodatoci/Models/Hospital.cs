using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace baziNaPodatoci.Models
{
    public class Hospital
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "hospitalName")]
        public string Name { get; set; }

        public string ImageUrl { get; set; }
        [Display(Name = "hospitalAddres")]
        public string Address { get; set; }


    }
}