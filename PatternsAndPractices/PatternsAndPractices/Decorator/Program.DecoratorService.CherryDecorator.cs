namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class DecoratorService
        {
            private class CherryDecorator : Decorator
            {
                public CherryDecorator(BakeryComponent baseComponent)
                    : base(baseComponent)
                {
                    this.name = "Cherry";
                    this.price = 2.0;
                }
            }
        }
    }
}