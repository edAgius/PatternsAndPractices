using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PatternsAndPractices;
using Console = System.Console;
using System.Data.Entity;

namespace PatternsAndPractices
{
    partial class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(string.Format("ed = {0}, Tom = {1}", "cool", "less cool"));
            //SRP
            Console.WriteLine("SRP");
            UserStorage s = new UserStorage();
            EmailStorage e = new EmailStorage();

            SRPService main = new SRPService(s,e);
            Console.WriteLine("_________________________________");
            Console.WriteLine("OCP");
            //OCP
            OCPService ocp = new OCPService();
            Console.WriteLine("_________________________________");
            Console.WriteLine("LSP");
            //LSP
            LSPService lsp = new LSPService();
            Console.WriteLine("_________________________________");
            Console.WriteLine("ISP");
            //ISP
            ISPService isp = new ISPService();
            Console.WriteLine("_________________________________");

            Console.WriteLine("DIP");
            //DIP
            DIPService sip = new DIPService();
            Console.WriteLine("_________________________________");
            Console.WriteLine("Law of Demeter");
            //Law of demeter
            Demeter dim = new Demeter();
            Console.WriteLine("_________________________________");
            Console.WriteLine("Factory pattern");
            //factory
            FactoryService factory = new FactoryService();
            Console.WriteLine("_________________________________");

            Console.WriteLine("Adaptor Pattern");
            //Adaptor pattern
            AdaptorService adaptorService = new AdaptorService();
            Console.WriteLine("_________________________________");

            Console.WriteLine("Decorator Pattern");
            //decorator pattern
            DecoratorService decoratorService = new DecoratorService();
            Console.WriteLine("_________________________________");


            Console.WriteLine("Repository Pattern");
            //Repository pattern
            RepositoryService RepositoryService = new RepositoryService();
            Console.WriteLine("_________________________________");


            Console.WriteLine("Tree Traversal");
            //BinaryTree Traversal
            BinaryTreeService BinaryTreeService = new BinaryTreeService();
            Console.WriteLine("_________________________________");

            Console.WriteLine("Number Swap");
            //Number Swap
            NumberSwapService NumberSwapService = new NumberSwapService();
            Console.WriteLine("_________________________________");

            Console.WriteLine(" EF Code FirstService");
            //EFCodeFirstService
            EFCodeFirstService EFCodeFirstService = new EFCodeFirstService();
            Console.WriteLine("_________________________________");
            //read
            Console.ReadLine();
        }

        public class EFCodeFirstService
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

            public class SchoolContext : DbContext
            {
                public SchoolContext() : base()
                {

                }
                public DbSet<Student> Students { get; set; }
                public DbSet<Grade> Grades { get; set; }

            }
            
            public class Student
            {
                public int StudentId { get; set; }
                public string Forename { get; set; }
                public string Surname { get; set; }
                public DateTime? DateOfBirth { get; set; }
                public byte gender { get; set; }
                public Grade Grade { get; set; }
            }
            public class Grade
            {
                public int GradeId { get; set; }
                public string GradeName { get; set; }
                public string Section { get; set; }

                public ICollection<Student> Students { get; set; }
            }


            public interface IRepository<T> where T : EntityBase
            {
                T GetById(Int64 id);

                void Create(T entity);

                void Delete(T entity);

                void Update(T entity);
            }

            public abstract class EntityBase
            {
                public Int64 Id { get; set; }
            }

            public class Repository<T> where T : EntityBase
            {
                public void Create(T entity)

                {

                    Console.WriteLine($"Create {entity.Id}");

                }

                public void Delete(T entity)

                {

                    Console.WriteLine($"Delete {entity.Id}");

                }

                public virtual T GetById(long id)

                {

                    Console.WriteLine($"Find {id}");
                    throw new NotImplementedException();

                }

                public void Update(T entity)

                {
                    Console.WriteLine($"Update {entity.Id}");
                }

            }

        }
    }
}



