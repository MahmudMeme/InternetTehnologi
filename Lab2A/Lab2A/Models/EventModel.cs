using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab2A.Models
{
    public class EventModel
    {
        public int id { get; set; }
        [Required(ErrorMessage ="polevo e zadlozitelno")]
        public string Name { get; set; }
        [Required(ErrorMessage = "polevo e zadlozitelno")]
        [StringLength(30,MinimumLength =5)]
        public string Location { get; set; }

    }
}