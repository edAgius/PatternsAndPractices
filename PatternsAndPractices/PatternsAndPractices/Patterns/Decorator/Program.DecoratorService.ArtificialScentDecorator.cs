namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class DecoratorService
        {
            private class ArtificialScentDecorator : Decorator
            {
                public ArtificialScentDecorator(BakeryComponent baseComponent)
                    : base(baseComponent)
                {
                    this.name = "Artificial Scent";
                    this.price = 3.0;
                }
            }
        }
    }
}