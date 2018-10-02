using System;

namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class Demeter
        {
            public Demeter()
            {
                DoWork();
            }
            public void DoWork()
            {
                PhoneNumber phone = new PhoneNumber();
                //get number
                //bad!
                //var number = phone.GetPhoneNumber();

                //get code

                //var code = number.GetAreaCode();

                //Better

                var code = phone.GetNumberWithAreaCode();

                //write
                Console.WriteLine(code);
            }
        }
    }
}