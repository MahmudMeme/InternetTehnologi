using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace baziNaPodatoci.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual List<Doctor> DocotorsList { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        // [MaxLength(5),MinLength(5)]
        //[Range(10,99999)]
        //@"^[0-9]{5}$"
        //@"\d{5}$"
        [RegularExpression(@"^[0-9]{5}$", ErrorMessage = "The patient's code must be 5 digits!")]
        [Display(Name = "Kod na Pacientot")]
        public int PatientCode { get; set; }

        public Patient()
        {
            DocotorsList = new List<Doctor>();
        }

    }
}