using Microsoft.EntityFrameworkCore;
using System;
using static SLACalculation.Helper.Enums;

namespace SLACalculation.Database
{
    public class SLACalcContext : DbContext
    {
        public SLACalcContext(DbContextOptions<SLACalcContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ComplaintType>()
                .HasData(
                    new ComplaintType
                    {
                        Id = Guid.NewGuid(),
                        Name = "ATM Card captured",
                        Priorty = Priorty.Low
                    },
                    new ComplaintType
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rude attitude of staff",
                        Priorty = Priorty.High
                    },
                    new ComplaintType
                    {
                        Id = Guid.NewGuid(),
                        Name = "Long waiting time in branches",
                        Priorty = Priorty.Medium
                    },
                    new ComplaintType
                    {
                        Id = Guid.NewGuid(),
                        Name = "Disputed transaction in credit card",
                        Priorty = Priorty.Medium
                    },
                    new ComplaintType
                    {
                        Id = Guid.NewGuid(),
                        Name = "Cash deposited but not reflected in the account",
                        Priorty = Priorty.Critical
                    },
                    new ComplaintType
                    {
                        Id = Guid.NewGuid(),
                        Name = "Credit card application takes too long",
                        Priorty = Priorty.Critical
                    });
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Complaint> Complaint { get; set; }
        public virtual DbSet<ComplaintType> ComplaintType { get; set; }
    }
}
