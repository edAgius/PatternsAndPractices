using System;

namespace PatternsAndPractices
{
    partial class Program
    {
        public class EmailStorage : IEmailStorage
        {
            public void Email(User user)
            {
                Console.WriteLine("email " + user.Name);
            }
        }
    }
}