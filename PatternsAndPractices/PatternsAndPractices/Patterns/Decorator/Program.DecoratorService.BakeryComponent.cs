namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class DecoratorService
        {
            public interface BakeryComponent
            {
                string GetName();
                double GetPrice();
            }
        }
    }
}