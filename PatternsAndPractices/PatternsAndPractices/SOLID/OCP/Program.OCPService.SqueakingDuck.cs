using System;

namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class OCPService
        {
            public class SqueakingDuck : IQuacking
            {
                public void Quack()
                {
                    Console.WriteLine("Squeak");
                }
            }
        }
    }
}