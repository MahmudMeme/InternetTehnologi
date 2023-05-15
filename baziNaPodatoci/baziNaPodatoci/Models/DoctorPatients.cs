using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace baziNaPodatoci.Models
{
    public class DoctorPatients
    {
        public int DocotrId { get; set; }
        public Doctor Doctor { get; set; }

        public List<Patient> PatientsList { get; set; }
        public int PatientId { get; set; }

        public DoctorPatients()
        {
            PatientsList = new List<Patient>();
        }
    }
}