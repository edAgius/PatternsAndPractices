namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class Demeter
        {
            public class PhoneNumber
            {
                public string GetNumberWithAreaCode()
                {
                    var number = GetPhoneNumber();
                    return GetAreaCode(number);
                }

                public string GetPhoneNumber()
                {
                    return "CODE123";
                }

                public string GetAreaCode(string Number)
                {
                    return Number.Substring(0, 4);
                }
            }
        }
    }
}