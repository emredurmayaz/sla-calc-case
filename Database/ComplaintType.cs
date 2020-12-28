using System;
using System.Collections.Generic;
using static SLACalculation.Helper.Enums;

namespace SLACalculation.Database
{
    public class ComplaintType
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public Priorty Priorty { get; set; }

        // FK
        public ICollection<Complaint> Complaints { get; set; }

        public ComplaintType()
        {
            Complaints = new List<Complaint>();
        }
    }
}