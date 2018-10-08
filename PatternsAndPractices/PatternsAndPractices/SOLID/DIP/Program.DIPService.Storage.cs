using System;

namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class DIPService
        {
            public class Storage : IStorage
            {
                public void Save(string text)
                {
                    Console.WriteLine("saving " + text);
                }
            }
        }
    }
}