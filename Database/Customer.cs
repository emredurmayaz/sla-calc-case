using System;
using System.Collections.Generic;
using static SLACalculation.Helper.Enums;

namespace SLACalculation.Database
{
    public class Customer
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public CustomerSegment Segment { get; set; }

        // FK
        public ICollection<Complaint> Complaints { get; set; }

        public Customer()
        {
            Complaints = new List<Complaint>();
        }
    }
}