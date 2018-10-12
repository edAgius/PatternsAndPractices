using System.Data.Entity;

namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class EFCodeFirstService
        {
            public class SchoolContext : DbContext
            {
                public SchoolContext() : base()
                {

                }
                public DbSet<Student> Students { get; set; }
                public DbSet<Grade> Grades { get; set; }

            }
        }
    }
}