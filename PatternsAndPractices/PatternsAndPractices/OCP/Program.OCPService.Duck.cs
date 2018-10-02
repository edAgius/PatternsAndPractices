using System;

namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class OCPService
        {
            public abstract class Duck : Bird
            {
                public void Crispy() { Console.WriteLine("Crispy"); }
            }
        }
    }
}