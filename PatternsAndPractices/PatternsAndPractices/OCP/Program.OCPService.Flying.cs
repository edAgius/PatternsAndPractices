using System;

namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class OCPService
        {
            public class Flying : IFlying
            {
                public void Fly()
                {
                    Console.WriteLine("Fly");
                }
            }
        }
    }
}