namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class DecoratorService
        {
            public class ButteryBiscuitBase : BakeryComponent
            {
                private string name = "Buttery Biscuit Base";
                private double price = 10000.0;

                public string GetName()
                {
                    return name;
                }

                public double GetPrice()
                {
                    return price;
                }
            }
        }
    }
}