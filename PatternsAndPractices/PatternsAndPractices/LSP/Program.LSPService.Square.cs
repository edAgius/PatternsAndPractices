using System;

namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class LSPService
        {
            public class Square : Shape
            {
                public int Sides;

                public void CalculateArea()
                {
                    Console.WriteLine(Sides * Sides);
                }

            }
        }
    }
}