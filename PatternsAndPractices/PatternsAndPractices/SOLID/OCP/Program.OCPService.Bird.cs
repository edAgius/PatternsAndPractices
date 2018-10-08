using System;

namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class OCPService
        {
            public abstract class Bird
            {
                public void Waddle() { Console.WriteLine("Waddle"); }

                public virtual void Quack() { }

                public void Swim() { Console.WriteLine("Swim"); }

                public virtual void Fly() { Console.WriteLine("Fly"); }
            }
        }
    }
}