using System;

namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class LSPService
        {
            public class Rectangle : Shape
            {
                public virtual int Height { get; set; }
                public virtual int Width { get; set; }

                public void CalculateArea()
                {
                    Console.WriteLine(Height * Width);
                }
            }
        }
    }
}