using Microsoft.EntityFrameworkCore;

namespace SLACalculation.Database
{
    public class SLACalcContext : DbContext
    {
        public SLACalcContext(DbContextOptions<SLACalcContext> options)
            : base(options)
        {

        }

        //public virtual DbSet<Test> Test { get; set; }
    }
}
