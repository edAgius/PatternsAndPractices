using System.Collections.Generic;

namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class LSPService
        {
            public LSPService()
            {
                Rectangle r = new Rectangle { Height = 2, Width = 3 };
                Square s = new Square { Sides = 3 };

                r.CalculateArea();
                s.CalculateArea();


                Shape newR = new Rectangle { Height = 2, Width = 3 };
                Shape newS = new Square { Sides = 3 };


                ((Rectangle)newR).CalculateArea();
                ((Square)newS).CalculateArea();

            }
        }
    }
}