using System;

namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class FactoryService
        {
            private class ExhaustFan : IFan
            {
                public void SwitchOn()
                {
                    Console.WriteLine("On");
                }
                public void SwitchOff()
                {
                    Console.WriteLine("Off");
                }
            }
        }
    }
}