using System;
using System.ComponentModel.DataAnnotations;

namespace SLACalculation.Database
{
    public class Complaint
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Text { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public int WorkMinutes { get; set; }
        [Required]
        public DateTime ResolutionDate { get; set; }

        // FK
        [Required]
        public Guid ComplaintTypeId { get; set; }
        public ComplaintType ComplaintType { get; set; }

        [Required]
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
