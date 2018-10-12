using System;

namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class EFCodeFirstService
        {
            public EFCodeFirstService()
            {
                using (var ctx = new SchoolContext())
                {
                    var stud = new Student() { Surname = "Bill" };

                    ctx.Students.Add(stud);
                    ctx.SaveChanges();
                    var studs = ctx.Students;
                    foreach (var student in studs)
                    {
                        var text = $"id ={student.StudentId}, name = {student.Surname}";
                        Console.WriteLine(text);
                    }
                }
            }
        }
    }
}