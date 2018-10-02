using System;

namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class OCPService
        {
            public class QuackingDuck : IQuacking
            {
                public void Quack()
                {
                    Console.WriteLine("Quack");
                }
            }
        }
    }
}