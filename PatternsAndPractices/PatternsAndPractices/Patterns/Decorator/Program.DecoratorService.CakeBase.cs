namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class DecoratorService
        {
            public class CakeBase : BakeryComponent
            {
                private string name = "Cake Base";
                private double price = 200.0;

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