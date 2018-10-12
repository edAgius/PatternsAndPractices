using System.Collections.Generic;

namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class EFCodeFirstService
        {
            public class Grade
            {
                public int GradeId { get; set; }
                public string GradeName { get; set; }
                public string Section { get; set; }

                public ICollection<Student> Students { get; set; }
            }
        }
    }
}