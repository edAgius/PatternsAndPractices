using System;

namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class OCPService
        {
            public class Swimming : ISwimming
            {
                public void Swim()
                {
                    Console.WriteLine("Swim");
                }
            }
        }
    }
}