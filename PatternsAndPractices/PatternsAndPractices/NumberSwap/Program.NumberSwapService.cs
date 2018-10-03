using System;

namespace PatternsAndPractices
{
    partial class Program
    {
        public class NumberSwapService
        {
            public NumberSwapService()
            {
                int x = 10;
                int y = 5;
                Console.WriteLine($"x:{x}, y: {y}");
                x = x + y; //15
                Console.WriteLine($"x:{x}, y: {y}");
                y = x - y; //10
                Console.WriteLine($"x:{x}, y: {y}");
                x = x - y; //5
                Console.WriteLine($"x:{x}, y: {y}");


            }
        }
    }
}