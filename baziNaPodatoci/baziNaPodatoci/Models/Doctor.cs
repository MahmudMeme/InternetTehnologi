using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace baziNaPodatoci.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public Hospital WorkHospital { get; set; }

        public virtual List<Patient> PatientsList { get; set; }

        public Doctor()
        {
            PatientsList = new List<Patient>();
        }
    }
}