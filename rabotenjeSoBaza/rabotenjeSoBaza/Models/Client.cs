using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace rabotenjeSoBaza.Models
{
    public class Clint
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Range(1, 99, ErrorMessage = "godinite se pomegu  1 i 99")]
        public int Age { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string ClientCard { get; set; }
        public virtual List<Movie> MovieList { get; set; }

        public Clint()
        {
            MovieList = new List<Movie>();
        }
    }
}