using System;

namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class DIPService
        {
            public class Logger : ILogger
            {
                public void log(string logText)
                {
                    Console.WriteLine("logging " + logText);
                }
            }
        }
    }
}