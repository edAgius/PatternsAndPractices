using System;

namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class EFCodeFirstService
        {
            public class Student
            {
                public int StudentId { get; set; }
                public string Forename { get; set; }
                public string Surname { get; set; }
                public DateTime? DateOfBirth { get; set; }
                public byte gender { get; set; }
                public Grade Grade { get; set; }
            }
        }
    }
}