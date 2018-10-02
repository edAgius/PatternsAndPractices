using System;

namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class OCPService
        {
            public class OoohDuck : IQuacking
            {
                public void Quack()
                {
                    Console.WriteLine("OOOH");
                }
            }
        }
    }
}