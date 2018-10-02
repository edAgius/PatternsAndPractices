using System;

namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class OCPService
        {
            public class NoFly : IFlying
            {
                public void Fly()
                {
                    Console.WriteLine("No Fly");
                }
            }
        }
    }
}