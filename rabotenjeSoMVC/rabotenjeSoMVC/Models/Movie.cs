﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace rabotenjeSoMVC.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string DonwlaudUrl { get; set; }
        public string ImageUrl { get; set; }
        public float reating { get; set; }


    }
}