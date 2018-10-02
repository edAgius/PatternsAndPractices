namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class DecoratorService
        {
            private class CreamDecorator : Decorator
            {
                public CreamDecorator(BakeryComponent baseComponent)
                    : base(baseComponent)
                {
                    this.name = "Cream";
                    this.price = 1.0;
                }
            }
        }
    }
}