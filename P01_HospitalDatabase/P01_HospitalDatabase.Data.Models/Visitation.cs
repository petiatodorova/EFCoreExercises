using System;
using System.Collections.Generic;
using System.Text;

namespace P01_HospitalDatabase.Data.Models
{
    public class Visitation
    {
        public int VisitationId { get; set; }

        public DateTime Date { get; set; }

        public string Comments { get; set; }

        // navigation property Patient + Foreign Key PatientId
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}
